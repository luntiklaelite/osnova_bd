using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osnova_just_bd.database
{
    public class DB
    {
        static User localUser;

        public struct Params
        {
            public string name;
            public object value;

            public Params(string name, object value)
            {
                this.name = name;
                this.value = value;
            }
        }

        public static void deAuth()
        {
            localUser = null;
            new Auth().Show();
        }

        public static bool auth(string login, string pass)
        {
            DataTable table;
            DB.Init().select("SELECT * FROM `users` WHERE `login` = @login AND `pass` = @pass", new List<Params>() { new Params("@login", login), new Params("@pass", pass) }, out table);
            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Неправильный логин или пароль!");
                return false;
            }
            localUser = new User(table.Rows[0]);
            return true;
        }

        static MySqlConnection conn;

        private static DB instance; 
        public static DB Init() // возвращает единственный экземпляр класса для подключений
        {
            if (instance == null)
                instance = new DB();
            return instance;
        }

        public static bool connect()
        {
            string server = Properties.Settings.Default.DB_Server;
            string user = Properties.Settings.Default.DB_Login;
            string pass = Properties.Settings.Default.DB_Pass;
            string db = Properties.Settings.Default.DB_DB;
            string connStr = $"Server={server};User ID={user};password={pass};database={db};CharSet=utf8";
            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось подключиться к базе данных!");
                return false;
            }
            return true;
        }

        public DB()
        {
            connect();
        }

        private MySqlCommand genCommand(string comm, List<Params> list) // создаёт запрос с параметрами
        {
            MySqlCommand command = new MySqlCommand(comm, getConnection());
            foreach (Params param in list)
            {
                command.Parameters.AddWithValue(param.name, param.value);
            }
            return command;
        }

        public bool exec(string sql, List<Params> list) // запрос в одну сторону
        {
            MySqlCommand command = genCommand(sql, list);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка с отправкой запроса к базе данных");
                return false;
            }
            return true;
        }

        public bool select(string sql, List<Params> list, out DataTable table) // запрос с селектом
        {
            MySqlCommand command = genCommand(sql, list);
            table = new DataTable();
            try
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    table.Load(reader);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка с загрузкой данных в таблицу!");
                return false;
            }
            return true;
        }

        public MySqlConnection getConnection()
        {
            return conn;
        }

    }
}
