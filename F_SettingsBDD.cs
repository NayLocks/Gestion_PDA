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
    public partial class F_SettingsBDD : Form
    {
        public F_SettingsBDD()
        {
            InitializeComponent();
            tb_bdd_host.Select();

            tb_bdd_host.Text = Properties.Settings.Default.bdd_host;
            tb_bdd_database.Text = Properties.Settings.Default.bdd_database;
            tb_bdd_port.Text = Properties.Settings.Default.bdd_port;
            tb_bdd_username.Text = Properties.Settings.Default.bdd_username;
            tb_bdd_password.Text = Properties.Settings.Default.bdd_password;
        }

        private void Bt_settings_save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.bdd_host = tb_bdd_host.Text;
            Properties.Settings.Default.bdd_database = tb_bdd_database.Text;
            Properties.Settings.Default.bdd_port = tb_bdd_port.Text;
            Properties.Settings.Default.bdd_username = tb_bdd_username.Text;
            Properties.Settings.Default.bdd_password = tb_bdd_password.Text;

            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void Close_app(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
