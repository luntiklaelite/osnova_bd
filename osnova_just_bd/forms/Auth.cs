using osnova_just_bd.database;
using osnova_just_bd.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static osnova_just_bd.database.DB;

namespace osnova_just_bd
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
            FormClosed += delegate { Application.Exit(); }; // закрывает приложение полностью
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new settingsBD().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(DB.auth(login.Text, pass.Text))
            {
                new mainForm().Show();
                Hide();
            }
            
        }
    }
}
