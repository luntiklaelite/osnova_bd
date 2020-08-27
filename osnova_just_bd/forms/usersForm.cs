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
    public partial class usersForm : Form
    {
        public usersForm()
        {
            InitializeComponent();
            refreshGrid();
        }

        void refreshGrid()
        {
            MainGrid.Rows.Clear();
            foreach(User u in User.getUsers().Where(u => u.login.Contains(tb_Search.Text) || u.pass.Contains(tb_Search.Text) || u.ID.ToString() == tb_Search.Text))
            {
                int r = MainGrid.Rows.Add(u.ID, u.login, u.pass);
                MainGrid.Rows[r].Tag = u;
            }
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            if(tb_login.Text == "" || tb_pass.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            if(User.Add(tb_login.Text, tb_pass.Text))
                MessageBox.Show("Успешно!");
            refreshGrid();
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void but_dell_Click(object sender, EventArgs e)
        {
            if(MainGrid.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите строку!");
                return;
            }
            if((MainGrid.SelectedRows[0].Tag as User).Delete())
                MessageBox.Show("Успешно!");
            refreshGrid();
        }

        private void but_edit_Click(object sender, EventArgs e)
        {
            if (MainGrid.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите строку!");
                return;
            }
            if (tb_login.Text == "" || tb_pass.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            User u = MainGrid.SelectedRows[0].Tag as User;
            u.login = tb_login.Text;
            u.pass = tb_pass.Text;
            if (u.Update())
                MessageBox.Show("Успешно!");
            refreshGrid();
        }
    }
}
