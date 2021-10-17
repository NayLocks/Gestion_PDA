using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_PDA
{
    class C_Initialisation
    {
		public static void Reinitialize(MySqlConnection cn, DataGridView dtgPDA, DataGridView dtgBR, DataGridView dtgBL, DataGridView dtgSIM, DataGridView dtgCOMPANY, ComboBox cm_company, ComboBox cm_no_sim, DataGridView dtgUSERS, DataGridView dtgFACT)
		{
			dtgPDA.Rows.Clear();
			dtgSIM.Rows.Clear();
			dtgCOMPANY.Rows.Clear();
			dtgBR.Rows.Clear();
			dtgBL.Rows.Clear();
			dtgUSERS.Rows.Clear();
			dtgFACT.Rows.Clear();
			cm_company.Items.Clear();
			cm_no_sim.Items.Clear();
			C_Initialisation.Dtg_TAB(cn, dtgPDA, dtgSIM, dtgBR, dtgBL, dtgCOMPANY, dtgUSERS, dtgFACT);
			C_Initialisation.Choice(cn, cm_company, cm_no_sim);
			C_Initialisation.ColorDtgPDA(dtgPDA);
		}

		public static void Dtg_TAB(MySqlConnection cn, DataGridView dtgPDA, DataGridView dtgSIM, DataGridView dtgBR, DataGridView dtgBL, DataGridView dtgCOMPANY, DataGridView dtgUSERS, DataGridView dtgFACT)
		{
			MySqlCommand cmdSQL;
			try
			{
				if (cn.State == System.Data.ConnectionState.Closed)
				{
					cn.Open();
					cmdSQL = new MySqlCommand("SELECT * FROM pda JOIN companies AS c ON c.id = pda.p_company_id JOIN sim AS s ON s.id = p_no_sim_id WHERE p_imei != 'TEST' ORDER BY c.c_name, p_no_pda", cn);
					using (MySqlDataReader Lire = cmdSQL.ExecuteReader())
					{
						while (Lire.Read())
						{
							dtgPDA.Rows.Add(Lire["c_name"].ToString(), Lire["p_no_pda"].ToString(), Lire["p_imei"].ToString(), Lire["p_no_serial"].ToString(), Lire["s_no_phone"].ToString(), Lire["s_no_sim"].ToString(), Lire["p_firstname"].ToString(), Lire["p_lastname"].ToString(), Lire["p_type"].ToString(), Lire["p_problem"].ToString(), Lire["id"].ToString());
						}
					}

					cmdSQL = new MySqlCommand("SELECT * FROM companies", cn);
					using (MySqlDataReader Lire = cmdSQL.ExecuteReader())
					{
						while (Lire.Read())
						{
							dtgCOMPANY.Rows.Add(Lire["id"].ToString(), Lire["c_name"].ToString());
						}
					}

					cmdSQL = new MySqlCommand("SELECT * FROM sim", cn);
					using (MySqlDataReader Lire = cmdSQL.ExecuteReader())
					{
						while (Lire.Read())
						{
							dtgSIM.Rows.Add(Lire["id"].ToString(), Lire["s_no_phone"].ToString(), Lire["s_no_sim"].ToString());
						}
					}

					
					cmdSQL = new MySqlCommand("SELECT *, DATE_FORMAT(d_date, '%d/%m/%Y') AS date FROM documents AS d JOIN pda AS p ON p.id = d.d_no_pda_id WHERE d_type = 'BR' ORDER BY d_date DESC", cn);
					using (MySqlDataReader Lire = cmdSQL.ExecuteReader())
					{
						while (Lire.Read())
						{
							dtgBR.Rows.Add(Lire["p_no_pda"].ToString(), Lire["p_no_serial"].ToString(), Lire["d_date"].ToString(), Lire["d_type"].ToString(), Lire["d_path"].ToString());
						}
					}

					cmdSQL = new MySqlCommand("SELECT *, DATE_FORMAT(d_date, '%d/%m/%Y') AS date FROM documents AS d JOIN pda AS p ON p.id = d.d_no_pda_id WHERE d_type = 'BL' ORDER BY d_date DESC", cn);
					using (MySqlDataReader Lire = cmdSQL.ExecuteReader())
					{
						while (Lire.Read())
						{
							dtgBL.Rows.Add(Lire["p_no_pda"].ToString(), Lire["p_no_serial"].ToString(), Lire["d_date"].ToString(), Lire["d_type"].ToString(), Lire["d_path"].ToString());
						}
					}

					cmdSQL = new MySqlCommand("SELECT *, DATE_FORMAT(d_date, '%d/%m/%Y') AS date FROM documents AS d JOIN pda AS p ON p.id = d.d_no_pda_id WHERE d_type = 'FACT' ORDER BY d_date DESC", cn);
					using (MySqlDataReader Lire = cmdSQL.ExecuteReader())
					{
						while (Lire.Read())
						{
							dtgFACT.Rows.Add(Lire["d_path_la_poste"].ToString(), Lire["d_montant"].ToString(), Lire["d_date"].ToString(), Lire["d_type"].ToString(), Lire["d_path"].ToString());
						}
					}

					cmdSQL = new MySqlCommand("SELECT * FROM users ORDER BY u_username ASC", cn);
					using (MySqlDataReader Lire = cmdSQL.ExecuteReader())
					{
						while (Lire.Read())
						{
							dtgUSERS.Rows.Add(Lire["u_username"].ToString(), Lire["u_name"].ToString(), Lire["u_mail"].ToString(), Lire["u_is_actived"].ToString());
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

		public static void Choice(MySqlConnection cn, ComboBox cm_company, ComboBox cm_no_sim)
		{
			MySqlCommand cmdSQL;
			try
			{
				if (cn.State == System.Data.ConnectionState.Closed)
				{
					cn.Open();
					cmdSQL = new MySqlCommand("SELECT * FROM companies", cn);
					using (MySqlDataReader Lire = cmdSQL.ExecuteReader())
					{
						while (Lire.Read())
						{
							cm_company.Items.Add(Lire["c_name"].ToString());
						}
					}

					cmdSQL = new MySqlCommand("SELECT * FROM sim", cn);
					using (MySqlDataReader Lire = cmdSQL.ExecuteReader())
					{
						while (Lire.Read())
						{
							cm_no_sim.Items.Add(Lire["s_no_sim"].ToString());
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

		public static void ColorDtgPDA(DataGridView dtg_PDA)
		{
			int lignes = dtg_PDA.Rows.Count;
			for (int i = 0; i <= lignes - 1; i++)
			{
				switch (dtg_PDA.Rows[i].Cells[0].Value)
				{

					case "ARDENNES PRIMEURS":
						dtg_PDA.Rows[i].DefaultCellStyle.BackColor = Color.Cyan;
						break;

					case "DIFFORVERT":
						dtg_PDA.Rows[i].DefaultCellStyle.BackColor = Color.LightSeaGreen;
						break;

					case "RIBEGROUPE":
						dtg_PDA.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
						break;

					case "RIBEPRIM":
						dtg_PDA.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
						break;

					case "RODAFRUITS":
						dtg_PDA.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
						break;

					case "VELDERS":
						dtg_PDA.Rows[i].DefaultCellStyle.BackColor = Color.Green;
						break;

					case "HUB ONE":
						dtg_PDA.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
						break;

					case "TEST":
						dtg_PDA.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
						break;

					default:
						break;
				}
			}
		}
	}
}
