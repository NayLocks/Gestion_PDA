using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_PDA
{
    class AddSQL
    {
		public static void AddNoSIM(MySqlConnection cn, TextBox tb_s_no_phone, TextBox tb_s_no_sim, DataGridView dtgSIM)
		{
			try
			{
				if (cn.State == System.Data.ConnectionState.Closed)
				{
					cn.Open();
					MySqlCommand cmd = cn.CreateCommand();
					cmd.CommandText = "INSERT INTO `sim`(`s_no_phone`, `s_no_sim`) VALUES (@phone, @sim)";
					cmd.Parameters.Add("@phone", MySqlDbType.VarChar).Value = tb_s_no_phone.Text;
					cmd.Parameters.Add("@sim", MySqlDbType.VarChar).Value = tb_s_no_sim.Text;
					cmd.ExecuteNonQuery();
					cn.Close();
					cn.Open();
					MySqlCommand cmdAllPDA = new MySqlCommand("SELECT * FROM sim WHERE `s_no_sim`='" + tb_s_no_sim.Text + "' LIMIT 1", cn);
					using (MySqlDataReader Lire = cmdAllPDA.ExecuteReader())
					{
						while (Lire.Read())
						{
							dtgSIM.Rows.Add(Lire["s_id"].ToString(), Lire["s_no_phone"].ToString(), Lire["s_no_sim"].ToString());
						}
					};
					cn.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public static void AddCompany(MySqlConnection cn, TextBox tb_c_company, DataGridView dtgCOMPANY)
		{
			try
			{
				if (cn.State == System.Data.ConnectionState.Closed)
				{
					cn.Open();
					MySqlCommand cmd = cn.CreateCommand();
					cmd.CommandText = "INSERT INTO `companies`(`c_name`) VALUES (@company)";
					cmd.Parameters.Add("@company", MySqlDbType.VarChar).Value = tb_c_company.Text;
					cmd.ExecuteNonQuery();
					cn.Close();
					cn.Open();
					MySqlCommand cmdAllPDA = new MySqlCommand("SELECT * FROM companies WHERE `c_name`='" + tb_c_company.Text + "' LIMIT 1", cn);
					using (MySqlDataReader Lire = cmdAllPDA.ExecuteReader())
					{
						while (Lire.Read())
						{
							dtgCOMPANY.Rows.Add(Lire["c_id"].ToString(), Lire["c_name"].ToString());
						}
					};
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
