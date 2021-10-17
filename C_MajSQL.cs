using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_PDA
{
    class C_MajSQL
    {
		public static void MajPDA(MySqlConnection cn, ComboBox cm_company, ComboBox cm_no_sim, TextBox tb_no_pda, TextBox tb_firstname, TextBox tb_lastname, TextBox tb_problem, TextBox tb_imei, DataGridView dtgPDA)
		{
			int c_id = 0;
			int s_id = 0;
			string tel = "";
			try
			{
				if (cn.State == System.Data.ConnectionState.Closed)
				{
					cn.Open();
					MySqlCommand cmdCompany = new MySqlCommand("SELECT * FROM companies WHERE `c_name`='" + cm_company.Text + "' LIMIT 1", cn);
					using (MySqlDataReader Lire = cmdCompany.ExecuteReader())
					{
						while (Lire.Read())
						{
							c_id = Convert.ToInt32(Lire["id"].ToString());
						}
					}
					cn.Close();
					MySqlCommand cmdSim = new MySqlCommand("SELECT * FROM sim WHERE `s_no_sim`='" + cm_no_sim.Text + "' LIMIT 1", cn);
					cn.Open();
					using (MySqlDataReader Lire = cmdSim.ExecuteReader())
					{
						while (Lire.Read())
						{
							s_id = Convert.ToInt32(Lire["id"].ToString());
							tel = Lire["s_no_phone"].ToString();
						}
					}
					cn.Close();
					cn.Open();
					MySqlCommand cmd = cn.CreateCommand();
					cmd.CommandText = "UPDATE `pda` SET `p_company_id`=@company, `p_no_sim_id`=@sim,`p_no_pda`=@no_pda,`p_firstname`=@firstname,`p_lastname`=@lastname,`p_problem`=@problem WHERE `p_imei`=@imei";
					cmd.Parameters.Add("@sim", MySqlDbType.VarChar).Value = s_id.ToString();
					cmd.Parameters.Add("@no_pda", MySqlDbType.VarChar).Value = tb_no_pda.Text;
					cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = tb_firstname.Text;
					cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = tb_lastname.Text;
					cmd.Parameters.Add("@problem", MySqlDbType.VarChar).Value = tb_problem.Text;
					cmd.Parameters.Add("@imei", MySqlDbType.VarChar).Value = tb_imei.Text;
					cmd.Parameters.Add("@company", MySqlDbType.VarChar).Value = c_id.ToString();
					cmd.ExecuteNonQuery();
					cn.Close();
					foreach (DataGridViewRow row in dtgPDA.SelectedRows)
					{
						row.Cells[0].Value = cm_company.Text;
						row.Cells[1].Value = tb_no_pda.Text;
						row.Cells[4].Value = tel;
						row.Cells[5].Value = cm_no_sim.Text;
						row.Cells[6].Value = tb_firstname.Text;
						row.Cells[7].Value = tb_lastname.Text;
						row.Cells[9].Value = tb_problem.Text;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public static void MajNoSIM(MySqlConnection cn, TextBox tb_s_no_phone, TextBox tb_s_no_sim, TextBox tb_s_id, DataGridView dtgSIM)
		{
			try
			{
				if (cn.State == System.Data.ConnectionState.Closed)
				{
					cn.Open();
					MySqlCommand cmd = cn.CreateCommand();
					cmd.CommandText = "UPDATE `sim` SET `s_no_phone`=@phone, `s_no_sim`=@sim WHERE `id`=@id";
					cmd.Parameters.Add("@phone", MySqlDbType.VarChar).Value = tb_s_no_phone.Text;
					cmd.Parameters.Add("@sim", MySqlDbType.VarChar).Value = tb_s_no_sim.Text;
					cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = tb_s_id.Text;
					cmd.ExecuteNonQuery();
					foreach (DataGridViewRow row in dtgSIM.SelectedRows)
					{
						row.Cells[1].Value = tb_s_no_phone.Text;
						row.Cells[2].Value = tb_s_no_sim.Text;
					}
					cn.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public static void MajCompany(MySqlConnection cn, TextBox tb_c_company, TextBox tb_c_id, DataGridView dtgCOMPANY)
		{
			try
			{
				if (cn.State == System.Data.ConnectionState.Closed)
				{
					cn.Open();
					MySqlCommand cmd = cn.CreateCommand();
					cmd.CommandText = "UPDATE `companies` SET `c_name`=@company WHERE `id`=@id";
					cmd.Parameters.Add("@company", MySqlDbType.VarChar).Value = tb_c_company.Text;
					cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = tb_c_id.Text;
					cmd.ExecuteNonQuery();
					foreach (DataGridViewRow row in dtgCOMPANY.SelectedRows)
					{
						row.Cells[1].Value = tb_c_company.Text;
					}
					cn.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
