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
    public partial class F_Connection : Form
    {
        bool isNull = true;

        public F_Connection()
        {
            InitializeComponent(); 
            tb_username.Select();
        }

        private void Bt_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bt_validation_Click(object sender, EventArgs e)
        {
            ValidationConnection();
        }

        private void ValidationConnection()
        {

            if (tb_password.Text == "settings_sql")
            {
                Form settingsBDD = new F_SettingsBDD();
                settingsBDD.Show();
                this.Hide();
            }
            else if (tb_password.Text == "settings_ftp")
            {
                Form settingsFTP = new F_SettingsFTP();
                settingsFTP.Show();
                this.Hide();
            }
            else
            {
                MySqlConnection cn = new MySqlConnection("server=" + Properties.Settings.Default.bdd_host + ";uid=" + Properties.Settings.Default.bdd_username + ";pwd=" + Properties.Settings.Default.bdd_password + ";database=" + Properties.Settings.Default.bdd_database + ";port=" + Properties.Settings.Default.bdd_port + ";SSL Mode=None");

                try
                {
                    if (cn.State == System.Data.ConnectionState.Closed)
                    {
                        cn.Open();
                        MySqlCommand cmdSQL = new MySqlCommand("SELECT * FROM users WHERE u_username='" + tb_username.Text + "';", cn);
                        using (MySqlDataReader Lire = cmdSQL.ExecuteReader())
                        {
                            while (Lire.Read())
                            {
                                if (Lire["u_password"].ToString() == tb_password.Text)
                                {
                                    if (Lire["u_is_actived"].ToString() == "1")
                                    {
                                        Properties.Settings.Default.u_username = Lire["u_username"].ToString();
                                        Properties.Settings.Default.u_name = Lire["u_name"].ToString();
                                        Properties.Settings.Default.u_mail = Lire["u_mail"].ToString();
                                        Form main = new F_MainForm();
                                        main.Show();
                                        this.Hide();
                                        isNull = false;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Erreur 1002 : Cet utilisateur n'est pas activé !");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Erreur 1003: Le mot de passe est incorrect !");
                                }
                            }
                            if (isNull)
                            {
                                MessageBox.Show("Erreur 1001 : Cet utilisateur n'existe pas dans la base !");
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
        }

        private void valid_enter(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                ValidationConnection();
            }
        }
    }
}
