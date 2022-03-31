using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Linq;


namespace laboratoryWorkers
{
    public static class Account
    {
        public static string Login { get; set; } = null;
        public static string Password { get; set; } = null;
        public static string Update { get; set; } = null;
        public static string Insert { get; set; } = null;
        public static string Dictionary { get; set; } = null;

        public static void connectAccount(string login, string password)
        {
            using (var connection = new SQLiteConnection("Data Source=database.sqlite3"))
            {
                connection.Open();
                var context = new DataContext(connection);

                var query = context.GetTable<Accounts>().Where(u => u.Login == login && u.Password == password);

                if (query.Count() == 0)
                {
                    connection.Close();
                    return;
                }

                foreach (var rez in query)
                {
                    Login = rez.Login;
                    Password = rez.Password;
                    Update = rez.Update_employeed;
                    Insert = rez.Insert_employee;
                    Dictionary = rez.Allow_dictionary;
                }
                connection.Close();
            }
        }

        public static bool canEditDictionary()
        {
            if (Dictionary == "YES") return true;
            return false;
        }
        public static bool canAddWorker()
        {
            if (Insert == "YES") return true;
            return false;
        }
        public static bool canUpdWorker()
        {
            if (Update == "YES") return true;
            return false;
        }
    }
}
