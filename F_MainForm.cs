using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Gestion_PDA
{
    public partial class F_MainForm : Form
    {
        readonly MySqlConnection cn = new MySqlConnection("server=" + Properties.Settings.Default.bdd_host + ";uid=" + Properties.Settings.Default.bdd_username + ";pwd=" + Properties.Settings.Default.bdd_password + ";database=" + Properties.Settings.Default.bdd_database + ";port=" + Properties.Settings.Default.bdd_port + ";SSL Mode=None");
		bool isVisibled = false;
		bool upload = false;
		bool user_add = false;

        public F_MainForm()
        {
            InitializeComponent();
			
            C_Initialisation.Dtg_TAB(cn, dtgPDA, dtgSIM, dtgBR, dtgBL, dtgCOMPANY, dtgUSERS, dtgFACT);
			C_Initialisation.Choice(cn, cm_company, cm_no_sim);
			C_Initialisation.ColorDtgPDA(dtgPDA);
			Settings_Retour();

			lb_pda.Text = "NB PDA : " + dtgPDA.Rows.Count.ToString();
			lb_user.Text = Properties.Settings.Default.u_username + " : " + Properties.Settings.Default.u_name;
			cm_actif.Items.Add("ACTIVE");
			cm_actif.Items.Add("DESACTIVE");

			try
			{
				if (cn.State == System.Data.ConnectionState.Closed)
				{
					cn.Open();
					MySqlCommand cmdSQL = new MySqlCommand("SELECT *, DATE_FORMAT(d_date, '%d/%m/%Y') AS date FROM documents AS d JOIN pda AS p ON p.id = d.d_no_pda_id WHERE d_type = 'FACT' ORDER BY d_date DESC", cn);
					using (MySqlDataReader Lire = cmdSQL.ExecuteReader())
					{
						while (Lire.Read())
						{
							dtgCOLIS.Rows.Add(Lire["d_path_la_poste"].ToString(), Lire["d_montant"].ToString(), Lire["d_date"].ToString(), Lire["d_type"].ToString(), Lire["d_path"].ToString());
						}
					}
					cn.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		public void Settings_Retour()
        {
			try
			{
				if (cn.State == System.Data.ConnectionState.Closed)
				{
					cn.Open();
					MySqlCommand cmdSQL = new MySqlCommand("SELECT * FROM settings_retour LIMIT 1", cn);
					using (MySqlDataReader Lire = cmdSQL.ExecuteReader())
					{
						while (Lire.Read())
						{
							tb_company.Text = Lire["sr_company"].ToString();
							tb_interlocuteur.Text = Lire["sr_interlocuteur"].ToString();
							tb_address.Text = Lire["sr_address"].ToString();
							tb_zip_code.Text = Lire["sr_zip_code"].ToString();
							tb_city.Text = Lire["sr_city"].ToString();
							tb_no_phone.Text = Lire["sr_phone"].ToString();
							tb_no_fax.Text = Lire["sr_fax"].ToString();
							tb_address_mail.Text = Lire["sr_mail"].ToString();
						}
					}
					cn.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		/********************************************************************************************************
		 ***************************                                            *********************************
		 ***************************       DataGridView Selection Changed       *********************************
		 ***************************                                            *********************************
		 ********************************************************************************************************/

		private void DtgPDA_SelectionChanged(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dtgPDA.SelectedRows)
			{
				lb_title.Text = "IMEI : " + row.Cells[2].Value.ToString();
				cm_company.Text = row.Cells[0].Value.ToString();
                tb_no_pda.Text = row.Cells[1].Value.ToString();
				tb_imei.Text = row.Cells[2].Value.ToString();
				tb_no_serial.Text = row.Cells[3].Value.ToString();
				cm_no_sim.Text = row.Cells[5].Value.ToString();
				tb_firstname.Text = row.Cells[6].Value.ToString();
				tb_lastname.Text = row.Cells[7].Value.ToString();
				tb_type.Text = row.Cells[8].Value.ToString();
				tb_problem.Text = row.Cells[9].Value.ToString();
			}
		}

		private void DtgSIM_SelectionChanged(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dtgSIM.SelectedRows)
			{
				tb_s_id.Text = row.Cells[0].Value.ToString();
				tb_s_no_phone.Text = row.Cells[1].Value.ToString();
				tb_s_no_sim.Text = row.Cells[2].Value.ToString();
			}
		}
		private void DtgCOMPANY_SelectionChanged(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dtgCOMPANY.SelectedRows)
			{
				tb_c_id.Text = row.Cells[0].Value.ToString();
				tb_c_company.Text = row.Cells[1].Value.ToString();
			}
		}
		
		private void DtgBR_SelectionChanged(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dtgBR.SelectedRows)
			{
				webBR.Navigate("http://" + Properties.Settings.Default.ftp_host + "/Appli/Gestion_PDA/Documents/BR/" + row.Cells[4].Value.ToString());
			}
		}
		
		private void DtgBL_SelectionChanged(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dtgBL.SelectedRows)
			{
				webBL.Navigate("http://" + Properties.Settings.Default.ftp_host + "/Appli/Gestion_PDA/Documents/BL/" + row.Cells[4].Value.ToString());
			}
		}

		private void DtgFACT_SelectionChanged(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dtgFACT.SelectedRows)
			{
				webFACT.Navigate("http://" + Properties.Settings.Default.ftp_host + "/Appli/Gestion_PDA/Documents/FACT/" + row.Cells[4].Value.ToString());
			}
		}

		private void DtgUSERS_SelectionChanged(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dtgUSERS.SelectedRows)
			{
				tb_username.Enabled = false;
				user_add = false;
				bt_user_add.Text = "Ajouter un Utilisateur";
				tb_username.Text = row.Cells[0].Value.ToString();
				tb_name.Text = row.Cells[1].Value.ToString();
				tb_mail.Text = row.Cells[2].Value.ToString();
				if(row.Cells[3].Value.ToString() == "1")
                {
					cm_actif.Text = "ACTIVE";
                }
                else
                {
					cm_actif.Text = "DESACTIVE";
                }
			}
		}

		/********************************************************************************************************
		 ***************************                                            *********************************
		 ***************************                 BT MAJ SQL                 *********************************
		 ***************************                                            *********************************
		 ********************************************************************************************************/

		private void Bt_Maj_SIM_Click(object sender, EventArgs e)
		{
			C_MajSQL.MajNoSIM(cn, tb_s_no_phone, tb_s_no_sim, tb_s_id, dtgSIM);
			C_Initialisation.Reinitialize(cn, dtgPDA, dtgBR, dtgBL, dtgSIM, dtgCOMPANY, cm_company, cm_no_sim, dtgUSERS, dtgFACT);

		}

		private void Bt_Maj_Company_Click(object sender, EventArgs e)
		{

			C_MajSQL.MajCompany(cn, tb_c_company, tb_c_id, dtgCOMPANY);
			C_Initialisation.Reinitialize(cn, dtgPDA, dtgBR, dtgBL, dtgSIM, dtgCOMPANY, cm_company, cm_no_sim, dtgUSERS, dtgFACT);
		}

		private void Bt_Maj_PDA_Click(object sender, EventArgs e)
		{
			C_MajSQL.MajPDA(cn, cm_company, cm_no_sim, tb_no_pda, tb_firstname, tb_lastname, tb_problem, tb_imei, dtgPDA);
			C_Initialisation.Reinitialize(cn, dtgPDA, dtgBR, dtgBL, dtgSIM, dtgCOMPANY, cm_company, cm_no_sim, dtgUSERS, dtgFACT);
		}

		/********************************************************************************************************
		 ***************************                                            *********************************
		 ***************************                 BT ADD SQL                 *********************************
		 ***************************                                            *********************************
		 ********************************************************************************************************/

		private void Bt_Add_SIM_Click(object sender, EventArgs e)
		{
			C_AddSQL.AddNoSIM(cn, tb_s_no_phone, tb_s_no_sim, dtgSIM);
			C_Initialisation.Reinitialize(cn, dtgPDA, dtgBR, dtgBL, dtgSIM, dtgCOMPANY, cm_company, cm_no_sim, dtgUSERS, dtgFACT);
		}

		private void Bt_Add_Company_Click(object sender, EventArgs e)
		{
			C_AddSQL.AddCompany(cn, tb_c_company, dtgCOMPANY);
			C_Initialisation.Reinitialize(cn, dtgPDA, dtgBR, dtgBL, dtgSIM, dtgCOMPANY, cm_company, cm_no_sim, dtgUSERS, dtgFACT);
		}

		/********************************************************************************************************
		 ***************************                                            *********************************
		 ***************************                   EXPORT                   *********************************
		 ***************************                                            *********************************
		 ********************************************************************************************************/

		private void Bt_Export_Excel_Click(object sender, EventArgs e)
		{
			C_Export.ExcelGenerate(dtgPDA);
		}

		/********************************************************************************************************
		 ***************************                                            *********************************
		 ***************************                 PAGE TEST                  *********************************
		 ***************************                                            *********************************
		 ********************************************************************************************************/

        private void Bt_edit_br_Click(object sender, EventArgs e)
        {
			foreach (DataGridViewRow row in dtgPDA.SelectedRows)
			{
				string intPDA = row.Cells[10].Value.ToString();
				if (intPDA.Length == 1)
                {
					string url = @"http://gpda.ribetrans.com/fiche_retour/0" + row.Cells[10].Value.ToString();
					webBR.Navigate(url);
					upload = true;
                }
                else
                {
					string url = @"http://gpda.ribetrans.com/fiche_retour/" + row.Cells[10].Value.ToString();
					webBR.Navigate(url);
					upload = true;
				}
				
			}
		}

        private void WebBR_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
			if (upload == true)
			{
				upload = false;
				string URLPath = webBR.Url.ToString();
				string URLSerial = webBR.Url.ToString();
				URLPath = URLPath.Remove(0, 30);
				URLSerial = URLSerial.Remove(0, 44);
				string noPDA = "0";

				URLSerial = URLSerial.Substring(0, URLSerial.Length - 4);

				try
				{
					WebClient webClient = new WebClient();
					webClient.DownloadFile(webBR.Url.ToString(), Application.StartupPath + "/" + URLPath);

					var dirPath = Application.StartupPath + "/" + URLPath;

					using (WebClient client = new WebClient())
					{
						client.Credentials = new NetworkCredential(Properties.Settings.Default.ftp_username, Properties.Settings.Default.ftp_password);
						client.UploadFile("ftp://" + Properties.Settings.Default.ftp_host + "/Appli/Gestion_PDA/Documents/BR/" + URLPath, "STOR", dirPath);
					}

					try
					{
						if (cn.State == System.Data.ConnectionState.Closed)
						{
							cn.Open();
							MySqlCommand cmd = cn.CreateCommand();
							cmd = new MySqlCommand("SELECT * FROM pda WHERE p_no_serial = '" + URLSerial + "'", cn);
							using (MySqlDataReader Lire = cmd.ExecuteReader())
							{
								while (Lire.Read())
								{
									noPDA = Lire["id"].ToString();
								}
							}
							cn.Close();
							cn.Open();
							cmd = cn.CreateCommand();
							cmd.CommandText = "INSERT INTO `documents`(`d_no_pda_id`, `d_path`, `d_type`, `d_path_la_poste`) VALUES (@pda, @path, 'BR', '/')";
							cmd.Parameters.Add("@pda", MySqlDbType.VarChar).Value = noPDA;
							cmd.Parameters.Add("@path", MySqlDbType.VarChar).Value = URLPath;
							cmd.ExecuteNonQuery();
							cn.Close();

							System.IO.File.Delete(dirPath);
							C_Initialisation.Reinitialize(cn, dtgPDA, dtgBR, dtgBL, dtgSIM, dtgCOMPANY, cm_company, cm_no_sim, dtgUSERS, dtgFACT);
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}

				}
				catch (WebException b)
				{
					// Traitement des erreurs
					MessageBox.Show(b.ToString());
				}
			}
		}

        private void Close_app(object sender, FormClosingEventArgs e)
        {
			Application.Exit();
        }

        private void bt_user_add_Click(object sender, EventArgs e)
        {
			if(user_add == false)
            {
				tb_username.Enabled = true;
				user_add = true;
				tb_username.Clear();
				tb_name.Clear();
				tb_mail.Clear();
				cm_actif.Text = "ACTIVE";
				bt_user_add.Text = "VALIDER LA CREATION";
            }
            else
            {
				tb_username.Enabled = false;
				user_add = false;
				try
				{
					if (cn.State == System.Data.ConnectionState.Closed)
					{
						cn.Open();
						MySqlCommand cmd = cn.CreateCommand();
						cmd.CommandText = "INSERT INTO `users`(`u_username`, `u_password`, `u_name`, `u_mail`, `u_isActived`) VALUES (@username, 'rg', @name, @mail, '1')";
						cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = tb_username.Text;
						cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = tb_name.Text;
						cmd.Parameters.Add("@mail", MySqlDbType.VarChar).Value = tb_mail.Text;
						cmd.ExecuteNonQuery();
						cn.Close();
						C_Initialisation.Reinitialize(cn, dtgPDA, dtgBR, dtgBL, dtgSIM, dtgCOMPANY, cm_company, cm_no_sim, dtgUSERS, dtgFACT);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
        }

        private void bt_user_password_Click(object sender, EventArgs e)
        {
			Form password = new F_Password(dtgUSERS);
			password.Show();
        }

        private void bt_user_edit_Click(object sender, EventArgs e)
        {
			try
			{
				if (cn.State == System.Data.ConnectionState.Closed)
				{
					cn.Open();
					MySqlCommand cmd = cn.CreateCommand();
					cmd.CommandText = "UPDATE `users` SET `u_name`=@name, `u_mail`=@mail, `u_isActived`=@active WHERE `u_username`=@username";
					cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = tb_name.Text;
					cmd.Parameters.Add("@mail", MySqlDbType.VarChar).Value = tb_mail.Text;
					cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = tb_username.Text;
					if(cm_actif.Text == "ACTIVE")
                    {
						cmd.Parameters.Add("@active", MySqlDbType.VarChar).Value = "1";
					}
                    else
					{
						cmd.Parameters.Add("@active", MySqlDbType.VarChar).Value = "0";
					}
					cmd.ExecuteNonQuery();
					foreach (DataGridViewRow row in dtgCOMPANY.SelectedRows)
					{
						row.Cells[1].Value = tb_c_company.Text;
					}
					cn.Close();
					C_Initialisation.Reinitialize(cn, dtgPDA, dtgBR, dtgBL, dtgSIM, dtgCOMPANY, cm_company, cm_no_sim, dtgUSERS, dtgFACT);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

        private void Bt_maj_settings_Click(object sender, EventArgs e)
        {
			try
			{
				if (cn.State == System.Data.ConnectionState.Closed)
				{
					cn.Open();
					MySqlCommand cmd = cn.CreateCommand();
					cmd.CommandText = "UPDATE `settings_retour` SET `sr_company`=@company, `sr_interlocuteur`=@interlocuteur, `sr_address`=@address, `sr_zip_code`=@zip_code, `sr_city`=@city, `sr_phone`=@phone, `sr_fax`=@fax, `sr_mail`=@mail WHERE `id`=@id";
					cmd.Parameters.Add("@company", MySqlDbType.VarChar).Value = tb_company.Text;
					cmd.Parameters.Add("@interlocuteur", MySqlDbType.VarChar).Value = tb_interlocuteur.Text;
					cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = tb_address.Text;
					cmd.Parameters.Add("@zip_code", MySqlDbType.VarChar).Value = tb_zip_code.Text;
					cmd.Parameters.Add("@city", MySqlDbType.VarChar).Value = tb_city.Text;
					cmd.Parameters.Add("@phone", MySqlDbType.VarChar).Value = tb_no_phone.Text;
					cmd.Parameters.Add("@fax", MySqlDbType.VarChar).Value = tb_no_fax.Text;
					cmd.Parameters.Add("@mail", MySqlDbType.VarChar).Value = tb_address_mail.Text;
					cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = "1";
					cmd.ExecuteNonQuery();
					cn.Close();
					MessageBox.Show("Paramètres Mis à Jour !!!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void DtgCOLIS_SelectionChanged(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dtgCOLIS.SelectedRows)
			{
				webCOLIS.Navigate("https://www.laposte.fr/outils/suivre-vos-envois?code=" + row.Cells[0].Value.ToString());
				//webCOLIS.Navigate("https://www.google.com/");
			}
		}
    }
}
