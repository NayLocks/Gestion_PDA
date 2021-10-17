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
    public partial class F_Password : Form
    {
        DataGridView dtg;
        public F_Password(DataGridView dtgUSERS)
        {
            InitializeComponent();
            foreach (DataGridViewRow row in dtgUSERS.SelectedRows)
            {
                dtg = dtgUSERS;
                lb_user.Text = "Nouveau mot de passe : " + row.Cells[0].Value.ToString();
                tb_password.Select();
            }
        }



        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Change_Password()
        {
            foreach (DataGridViewRow row in dtg.SelectedRows)
            {
                MySqlConnection cn = new MySqlConnection("server=" + Properties.Settings.Default.bdd_host + ";uid=" + Properties.Settings.Default.bdd_username + ";pwd=" + Properties.Settings.Default.bdd_password + ";database=" + Properties.Settings.Default.bdd_database + ";port=" + Properties.Settings.Default.bdd_port + ";SSL Mode=None");
                try
                {
                    if (cn.State == System.Data.ConnectionState.Closed)
                    {
                        cn.Open();
                        MySqlCommand cmd = cn.CreateCommand();
                        cmd.CommandText = "UPDATE `users` SET `u_password`=@password WHERE `u_username`=@username";
                        cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = row.Cells[0].Value.ToString();
                        cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = tb_password.Text;
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bt_validation_Click(object sender, EventArgs e)
        {
            Change_Password();
		}

        private void valid_enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Change_Password();
            }
        }
    }
}
