using osnova_just_bd.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osnova_just_bd.forms
{
    public partial class settingsBD : Form
    {
        public settingsBD()
        {
            InitializeComponent();
            panel1.Visible = true;
        }

        private void but_auth_Click(object sender, EventArgs e)
        {
            if (adminpass.Text != "MIDorFEED")
                return;
            panel1.Visible = false;
            save.Enabled = true;
        }

        private void save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DB_Server = server.Text;
            Properties.Settings.Default.DB_Login = userid.Text;
            Properties.Settings.Default.DB_Pass = pass.Text;
            Properties.Settings.Default.DB_DB = database.Text;
            Properties.Settings.Default.Save();
            if (DB.connect())
                this.Close();
        }
    }
}
