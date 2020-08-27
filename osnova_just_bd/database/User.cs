using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static osnova_just_bd.database.DB;

namespace osnova_just_bd.database
{
    public class User
    {

        public int ID { get; set; }
        public string login { get; set; }
        public string pass { get; set; }

        public User(DataRow row)
        {
            ID = Convert.ToInt32(row["ID"]);
            login = row["login"].ToString();
            pass = row["pass"].ToString();
        }

        
        public static bool Add(string login, string pass)
        {
            if (!DB.Init().exec("INSERT INTO `users` (`login`, `pass`) VALUES (@login, @pass)", new List<Params>() { new Params("@login", login), new Params("@pass", pass) }))
                return false;
            return true;
        }

        public bool Delete()
        {
            if (!DB.Init().exec("DELETE FROM `users` WHERE `users`.`ID` = @id;", new List<Params> { new Params("@id", ID) }))
                return false;
            return true;
        }
        public bool Update()
        {
            if (DB.Init().exec("UPDATE `users` SET `login` = @login, `pass` = @pass WHERE `users`.`ID` = @id", new List<Params> { new Params("@login", login), new Params("@pass", pass), new Params("@id", ID) }))
                return true;
            return false;
        }


        public static List<User> getUsers()
        {
            DataTable table;
            List<User> users = new List<User>();
            if (DB.Init().select("SELECT * FROM `users`", new List<Params>(), out table))
            {
                foreach (DataRow row in table.Rows)
                {
                    users.Add(new User(row));
                }
            }
            return users;
        }
    }
}
