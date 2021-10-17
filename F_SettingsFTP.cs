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
    public partial class F_SettingsFTP : Form
    {
        public F_SettingsFTP()
        {
            InitializeComponent();
            tb_ftp_host.Select();

            tb_ftp_host.Text = Properties.Settings.Default.ftp_host;
            tb_ftp_port.Text = Properties.Settings.Default.ftp_port;
            tb_ftp_username.Text = Properties.Settings.Default.ftp_username;
            tb_ftp_password.Text = Properties.Settings.Default.ftp_password;
        }

        private void Bt_settings_save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ftp_host = tb_ftp_host.Text;
            Properties.Settings.Default.ftp_port = tb_ftp_port.Text;
            Properties.Settings.Default.ftp_username = tb_ftp_username.Text;
            Properties.Settings.Default.ftp_password = tb_ftp_password.Text;

            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void Close_app(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
