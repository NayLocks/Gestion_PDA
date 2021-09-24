using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_PDA
{
    public partial class MainForm : Form
    {
        readonly MySqlConnection cn = new MySqlConnection("server=" + Properties.Settings.Default.bdd_host + ";uid=" + Properties.Settings.Default.bdd_user + ";pwd=" + Properties.Settings.Default.bdd_password + ";database=" + Properties.Settings.Default.bdd_database + ";SSL Mode=None");
		bool isVisibled = false;

        public MainForm()
        {
            InitializeComponent();
            Initialisation.Dtg_TAB(cn, dtgPDA, dtgSIM, dtgBR, dtgBL, dtgCOMPANY);
			Initialisation.Choice(cn, cm_company, cm_no_sim);
			Initialisation.ColorDtgPDA(dtgPDA);


			lb_pda.Text = "NB PDA : " + dtgPDA.Rows.Count.ToString();
			tab_Control.TabPages.Remove(tab_Secret);
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
				webBR.Navigate("http://" + Properties.Settings.Default.ftp_host + "/Appli/Gestion_PDA/Documents/" + row.Cells[4].Value.ToString());
			}
		}
		
		private void DtgBL_SelectionChanged(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dtgBL.SelectedRows)
			{
				webBL.Navigate("http://" + Properties.Settings.Default.ftp_host + "/Appli/Gestion_PDA/Documents/" + row.Cells[4].Value.ToString());
			}
		}

		/********************************************************************************************************
		 ***************************                                            *********************************
		 ***************************                 BT MAJ SQL                 *********************************
		 ***************************                                            *********************************
		 ********************************************************************************************************/

		private void Bt_Maj_SIM_Click(object sender, EventArgs e)
		{
			MajSQL.MajNoSIM(cn, tb_s_no_phone, tb_s_no_sim, tb_s_id, dtgSIM);
			Initialisation.Reinitialize(cn, dtgPDA, dtgPDA, dtgPDA, dtgSIM, dtgCOMPANY, cm_company, cm_no_sim);

		}

		private void Bt_Maj_Company_Click(object sender, EventArgs e)
		{

			MajSQL.MajCompany(cn, tb_c_company, tb_c_id, dtgCOMPANY);
			Initialisation.Reinitialize(cn, dtgPDA, dtgPDA, dtgPDA, dtgSIM, dtgCOMPANY, cm_company, cm_no_sim);
		}

		private void Bt_Maj_PDA_Click(object sender, EventArgs e)
		{
			MajSQL.MajPDA(cn, cm_company, cm_no_sim, tb_no_pda, tb_firstname, tb_lastname, tb_problem, tb_imei, dtgPDA);
			Initialisation.Reinitialize(cn, dtgPDA, dtgPDA, dtgPDA, dtgSIM, dtgCOMPANY, cm_company, cm_no_sim);
		}

		/********************************************************************************************************
		 ***************************                                            *********************************
		 ***************************                 BT ADD SQL                 *********************************
		 ***************************                                            *********************************
		 ********************************************************************************************************/

		private void Bt_Add_SIM_Click(object sender, EventArgs e)
		{
			AddSQL.AddNoSIM(cn, tb_s_no_phone, tb_s_no_sim, dtgSIM);
			Initialisation.Reinitialize(cn, dtgPDA, dtgPDA, dtgPDA, dtgSIM, dtgCOMPANY, cm_company, cm_no_sim);
		}

		private void Bt_Add_Company_Click(object sender, EventArgs e)
		{
			AddSQL.AddCompany(cn, tb_c_company, dtgCOMPANY);
			Initialisation.Reinitialize(cn, dtgPDA, dtgPDA, dtgPDA, dtgSIM, dtgCOMPANY, cm_company, cm_no_sim);
		}

		/********************************************************************************************************
		 ***************************                                            *********************************
		 ***************************                   EXPORT                   *********************************
		 ***************************                                            *********************************
		 ********************************************************************************************************/

		private void Bt_Export_Excel_Click(object sender, EventArgs e)
		{
			Export.ExcelGenerate(dtgPDA);
		}

		/********************************************************************************************************
		 ***************************                                            *********************************
		 ***************************                 PAGE TEST                  *********************************
		 ***************************                                            *********************************
		 ********************************************************************************************************/

		private void Bt_Tab_Secret_Click(object sender, EventArgs e)
		{

			if (isVisibled)
			{
				tab_Control.TabPages.Remove(tab_Secret);
				isVisibled = false;
				tb_c_company.Clear();
			}
			else
			{
				if (tb_c_company.Text == Properties.Settings.Default.code_secret)
				{
					tab_Control.TabPages.Add(tab_Secret);
					isVisibled = true;
					tb_c_company.Clear();
				}
				else
				{
					tb_c_company.Clear();
				}
			}
		}
	}
}
