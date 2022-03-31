using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SQLite.Linq;
using System.IO;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Windows.Forms;


namespace laboratoryWorkers
{
    public interface IRow
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        long? Id { get; set; }
    }

    public interface IDictionaryRow
    {
        [Column(Name = "name")]
        string Name { get; set; }
    }

    [Table(Name = "account")]
    public class Accounts: IRow
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        public long? Id { get; set; }

        [Column(Name = "login")]
        public string Login { get; set; }

        [Column(Name = "password")]
        public string Password { get; set; }

        [Column(Name = "update_employee")]
        public string Update_employeed { get; set; }

        [Column(Name = "insert_employee")]
        public string Insert_employee { get; set; }

        [Column(Name = "allow_dictionary")]
        public string Allow_dictionary { get; set; }

    }

    [Table(Name = "gender")]
    public class Genders : IRow, IDictionaryRow
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        public long? Id { get; set; }
        [Column(Name = "name")]
        public string Name { get; set; }
    }

    [Table(Name = "family_status")]
    public class Family_status : IRow, IDictionaryRow
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        public long? Id { get; set; }
        [Column(Name = "name")]
        public string Name { get; set; }
    }

    [Table(Name = "position")]
    public class Position : IRow, IDictionaryRow
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        public long? Id { get; set; }
        [Column(Name = "name")]
        public string Name { get; set; }
    }

    [Table(Name = "academic_degree")]
    public class Academic_degree : IRow, IDictionaryRow
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        public long? Id { get; set; }
        [Column(Name = "name")]
        public string Name { get; set; }
    }

    [Table(Name = "laboratoryWorkers")]
    public class LaboratoryWorkers : IRow
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        public long? Id { get; set; }
        [Column(Name = "name")]
        public string Name { get; set; }
        [Column(Name = "surname")]
        public string Surname { get; set; }

        [Column(Name = "middlename")]
        public string Middlename { get; set; }

        [Column(Name = "birthday")]
        public DateTime Birthday { get; set; }

        [Column(Name = "gender")]
        public long Gender { get; set; }

        [Column(Name = "family_status")]
        public long Family_status { get; set; }

        [Column(Name = "have_children")]
        public string Have_children { get; set; }

        [Column(Name = "position")]
        public long Position { get; set; }

        [Column(Name = "academic_degree")]
        public long Academic_degree { get; set; }
    }
    public static class Database
    {
        public static void InitialDatabase()
        {
            if (!File.Exists("./Database.sqlite3"))
            {
                SQLiteConnection.CreateFile("Database.sqlite3");
                using (var connection = new SQLiteConnection("Data Source=Database.sqlite3"))
                {
                    connection.Open();
                    var context = new DataContext(connection);
                    int rezult = context.ExecuteCommand("CREATE TABLE account " + "(id INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE NOT NULL, " +
                                                                                       "login               VARCHAR UNIQUE NOT NULL, " +
                                                                                       "password            VARCHAR NOT NULL, " +
                                                                                       "update_employee     VARCHAR CHECK (update_employee = \"YES\" OR update_employee = \"NO\"), " +
                                                                                       "insert_employee     VARCHAR CHECK (insert_employee = \"YES\" OR insert_employee = \"NO\"), " +
                                                                                       "allow_dictionary    VARCHAR CHECK (allow_dictionary = \"YES\" OR allow_dictionary = \"NO\"));");

                    rezult = context.ExecuteCommand("CREATE TABLE academic_degree (id   INTEGER PRIMARY KEY UNIQUE NOT NULL," +
                                                                                  "name VARCHAR UNIQUE NOT NULL);");

                    rezult = context.ExecuteCommand("CREATE TABLE family_status (id   INTEGER PRIMARY KEY UNIQUE NOT NULL, " +
                                                                                "name VARCHAR UNIQUE NOT NULL); ");

                    rezult = context.ExecuteCommand("CREATE TABLE gender (id   INTEGER PRIMARY KEY UNIQUE NOT NULL, " +
                                                                         "name VARCHAR UNIQUE NOT NULL); ");

                    rezult = context.ExecuteCommand("CREATE TABLE position (id   INTEGER PRIMARY KEY UNIQUE NOT NULL, " +
                                                                           "name VARCHAR UNIQUE NOT NULL); ");

                    rezult = context.ExecuteCommand("CREATE TABLE laboratoryWorkers (id              INTEGER UNIQUE NOT NULL PRIMARY KEY, " +
                                                                                    "name            VARCHAR NOT NULL, " +
                                                                                    "surname         VARCHAR NOT NULL, " +
                                                                                    "middlename      VARCHAR NOT NULL, " +
                                                                                    "birthday        DATE, " +
                                                                                    "gender          INTEGER REFERENCES gender(id) ON DELETE RESTRICT, " +
                                                                                    "family_status   INTEGER REFERENCES family_status(id) ON DELETE RESTRICT, " +
                                                                                    "have_children   VARCHAR CHECK(have_children = \"YES\" OR have_children = \"NO\" OR have_children = \"\"), " +
                                                                                    "position        INTEGER REFERENCES position(id) ON DELETE RESTRICT, " +
                                                                                    "academic_degree INTEGER REFERENCES academic_degree(id) ON DELETE RESTRICT); ");

                    //главный аккаунт
                    Accounts mainAcc = new Accounts
                    {
                        Login = "admin",
                        Password = "admin",
                        Update_employeed = "YES",
                        Insert_employee = "YES",
                        Allow_dictionary = "YES"
                    };

                    context.GetTable<Accounts>().InsertOnSubmit(mainAcc);
                    context.SubmitChanges();
                    context.Dispose();

                    //ученые степени
                    List<Academic_degree> baseDegree = new List<Academic_degree>();
                    baseDegree.Add(new Academic_degree() { Name = "Кандидат наук" });
                    baseDegree.Add(new Academic_degree() { Name = "Доктор наук" });

                    foreach (var degree in baseDegree)
                    {
                        context = new DataContext(connection);
                        context.GetTable<Academic_degree>().InsertOnSubmit(degree);
                        context.SubmitChanges();
                        context.Dispose();
                    };

                    //должность
                    List<Position> basePosition = new List<Position>();

                    basePosition.Add(new Position() { Name = "Лаборант" });
                    basePosition.Add(new Position() { Name = "Ученый" });

                    foreach (var position in basePosition)
                    {
                        context = new DataContext(connection);
                        context.GetTable<Position>().InsertOnSubmit(position);
                        context.SubmitChanges();
                        context.Dispose();
                    }

                    //семейное положение (ну а вдруг введут что-то кроме женат/холост?)
                    List<Family_status> baseFamily_status = new List<Family_status>();
                    baseFamily_status.Add(new Family_status() { Name = "Женат" });
                    baseFamily_status.Add(new Family_status() { Name = "Замужем" });
                    baseFamily_status.Add(new Family_status() { Name = "Холост" });
                    baseFamily_status.Add(new Family_status() { Name = "Не замужем" });

                    foreach (var familyStatus in baseFamily_status)
                    {
                        context = new DataContext(connection);
                        context.GetTable<Family_status>().InsertOnSubmit(familyStatus);
                        context.SubmitChanges();
                        context.Dispose();
                    }

                    //Пол. Нет, ну а вдруг введут новый?! xD
                    List<Genders> baseGender = new List<Genders>();
                    baseGender.Add(new Genders() { Name = "Мужчина" });
                    baseGender.Add(new Genders() { Name = "Женщина" });

                    foreach (var gender in baseGender)
                    {
                        context = new DataContext(connection);
                        context.GetTable<Genders>().InsertOnSubmit(gender);
                        context.SubmitChanges();
                        context.Dispose();
                    }

                    List<LaboratoryWorkers> baseWorkers = new List<LaboratoryWorkers>();
                    baseWorkers.Add(new LaboratoryWorkers()
                    {
                        Name = "Евгений",
                        Surname = "Усанов",
                        Middlename = "Николаевич",
                        Birthday = new DateTime(1992, 4, 13),
                        Gender = 1,
                        Family_status = 3,
                        Have_children = "NO",
                        Position = 1,
                        Academic_degree = 1
                    });

                    baseWorkers.Add(new LaboratoryWorkers()
                    {
                        Name = "Александр",
                        Surname = "Агафонов",
                        Middlename = "Вячеславович",
                        Birthday = new DateTime(1992, 4, 13),
                        Gender = 1,
                        Family_status = 1,
                        Have_children = "YES",
                        Position = 2,
                        Academic_degree = 2
                    });

                    foreach (var worker in baseWorkers)
                    {
                        context = new DataContext(connection);
                        context.GetTable<LaboratoryWorkers>().InsertOnSubmit(worker);
                        context.SubmitChanges();
                        context.Dispose();
                    }

                    connection.Close();
                }
            }

            fillMainDatatable();
            fillDatatable(ref accounttable);
            fillDatatable(ref academdegrtable);
            fillDatatable(ref fstatustable);
            fillDatatable(ref gendertable);
            fillDatatable(ref positiontable);
        }

        //получить таблицу по запросу
        public static DataTable getDatatable(string sqlQuery)
        {
            using (var connection = new SQLiteConnection("Data Source=Database.sqlite3"))
            {
                DataTable dt = new DataTable();
                try
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    adapter.Fill(dt);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,
                              "Сообщение",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information,
                              MessageBoxDefaultButton.Button1);
                }
                finally
                {
                    connection.Close();
                }
                return dt;
            }
        }

        //заполнить главную таблицу
        public static void fillMainDatatable()
        {
            using (var connection = new SQLiteConnection("Data Source=Database.sqlite3"))
            {
                try
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(sqlMain, connection);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    datatable.Clear();
                    adapter.Fill(datatable);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,
                              "Сообщение",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information,
                              MessageBoxDefaultButton.Button1);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        //получить таблицу (не использовал но пусть будет)
        public static List<T> getDatatable<T>(List<T> table) where T : class, IRow
        {
            using (var connection = new SQLiteConnection("Data Source=Database.sqlite3"))
            {
                connection.Open();
                DataContext context = new DataContext(connection);
                table = context.GetTable<T>().ToList();
                context.Dispose();
                connection.Close();
                return table;
            }
        }

        //заполнить таблицу
        public static void fillDatatable<T>(ref List<T> table) where T : class, IRow
        {
            using (var connection = new SQLiteConnection("Data Source=Database.sqlite3"))
            {
                DataContext context = new DataContext(connection);
                try
                {
                    connection.Open();
                    table = context.GetTable<T>().ToList();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,
                              "Сообщение",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information,
                              MessageBoxDefaultButton.Button1);
                }
                finally
                {
                    context.Dispose();
                    connection.Close();
                }
            }
        }

        public static void dbSearch(string name, 
                                    string surname, 
                                    string middlename, 
                                    DateTime datetime, 
                                    bool datetimeActive,
                                    string havechildren,
                                    string gender,
                                    string familystatus,
                                    string position,
                                    string academicdegree)
        {

            DataTable tempDataTable = getDatatable(sqlMain);
            IEnumerable<DataRow> query = tempDataTable.AsEnumerable();

            if (name != null && name != "" && name != " ")
            {
                query = query.Where(u => u.Field<string>("Имя").ToUpper() == name.ToUpper());
            }

            if (surname != null && surname != "" && surname != " ")
            {
                query = query.Where(u => u.Field<string>("Фамилия").ToUpper() == surname.ToUpper());
            }

            if (middlename != null && middlename != "" && middlename != " ")
            {
                query = query.Where(u => u.Field<string>("Отчество").ToUpper() == middlename.ToUpper());
            }

            if (datetimeActive)
            {
                query = query.Where(u => u.Field<DateTime>("День рождения").ToShortDateString() == datetime.ToShortDateString());
            }

            if(havechildren != null && havechildren != "")
            {
                query = query.Where(u => u.Field<string>("Есть дети") == havechildren);
            }

            if(gender != "")
            {
                query = query.Where(u => u.Field<string>("Пол") == gender);
            }

            if (familystatus != "")
            {
                query = query.Where(u => u.Field<string>("Семейное положение") == familystatus);
            }

            if (position != "")
            {
                query = query.Where(u => u.Field<string>("Должность") == position);
            }

            if (academicdegree != "")
            {
                query = query.Where(u => u.Field<string>("Ученая степень") == academicdegree);
            }

            datatable = query.Count() > 0 ? query.CopyToDataTable() : datatable;
        }

        public static void dbadd<T>(T row) where T : class, IRow
        {
            using (var connection = new SQLiteConnection("Data Source=Database.sqlite3"))
            {
                var context = new DataContext(connection);
                try
                {
                    connection.Open();
                    context.GetTable<T>().InsertOnSubmit(row);
                    context.SubmitChanges();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,
                               "Сообщение",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information,
                               MessageBoxDefaultButton.Button1);
                }
                finally
                {
                    context.Dispose();
                    connection.Close();
                }
            }
        }

        public static void dbdel<T>(T row) where T : class, IRow
        {
            using (var connection = new SQLiteConnection("Data Source=Database.sqlite3"))
            {
                var context = new DataContext(connection);
                try 
                {
                    connection.Open();
                    var pragma = new SQLiteCommand("PRAGMA foreign_keys = true", connection);
                    pragma.ExecuteNonQuery();

                    row = context.GetTable<T>().Where(u => u.Id.Equals(row.Id)).SingleOrDefault();
                    context.GetTable<T>().DeleteOnSubmit(row);

                    context.SubmitChanges();
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message,
                                    "Сообщение",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information,
                                    MessageBoxDefaultButton.Button1);
                }
                finally 
                {
                    context.Dispose();
                    connection.Close();
                }
            }
        }

        public static void dbupd<T>(T row) where T : class, IRow
        {
            using (var connection = new SQLiteConnection("Data Source=Database.sqlite3"))
            {
                var context = new DataContext(connection);
                try
                {
                    connection.Open();
                    context.GetTable<T>().Attach(row);
                    context.Refresh(RefreshMode.KeepCurrentValues, row);
                    context.SubmitChanges();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,
                                    "Сообщение",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information,
                                    MessageBoxDefaultButton.Button1);
                }
                finally
                {
                    context.Dispose();
                    connection.Close();
                }
            }
        }

        public static T dbgetrow<T> (T table) where T : class, IRow
        {
            using (var connection = new SQLiteConnection("Data Source=Database.sqlite3"))
            {
                var context = new DataContext(connection);
                try
                {
                    connection.Open();
                    table = context.GetTable<T>().Where(u => u.Id.Equals(table.Id)).SingleOrDefault();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,
                                    "Сообщение",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information,
                                    MessageBoxDefaultButton.Button1);
                }
                finally 
                {
                    context.Dispose();
                    connection.Close();
                }
            }
            return table;
        }


        public static DataTable datatable = new DataTable();
        public static List<Accounts> accounttable;
        public static List<Academic_degree> academdegrtable;
        public static List<Family_status> fstatustable;
        public static List<Genders> gendertable;
        public static List<Position> positiontable;

        static public string sqlMain = "SELECT laboratoryWorkers.id, " +
                                              "laboratoryWorkers.name AS \"Имя\", " +
                                              "laboratoryWorkers.surname AS \"Фамилия\", " +
                                              "laboratoryWorkers.middlename AS \"Отчество\", " +
                                              "laboratoryWorkers.birthday AS \"День рождения\", " +
                                              "laboratoryWorkers.have_children AS \"Есть дети\", " +
                                              "gender.name AS \"Пол\", " +
                                              "family_status.name AS \"Семейное положение\", " +
                                              "position.name AS \"Должность\", " +
                                              "academic_degree.name AS \"Ученая степень\" " +
                                              "FROM laboratoryWorkers " +
                                              "LEFT JOIN gender ON laboratoryWorkers.gender = gender.id " +
                                              "LEFT JOIN family_status ON laboratoryWorkers.family_status = family_status.id " +
                                              "LEFT JOIN position ON laboratoryWorkers.position = position.id " +
                                              "LEFT JOIN academic_degree ON laboratoryWorkers.academic_degree = academic_degree.id; ";

        static public string sqlGender = "SELECT 0 as \"id\", " +
                                                "'' as \"name\" " +
                                          "UNION " +
                                         "SELECT id as \"id\", " +
                                                "name as \"name\"" +
                                           "FROM gender; ";

        static public string sqlFamilyStatus = "SELECT 0 as \"id\", " +
                                                      "'' as \"name\" " +
                                                "UNION " +
                                               "SELECT id as \"id\", " +
                                                 "name as \"name\"" +
                                                 "FROM family_status; ";

        static public string sqlPosition = "SELECT 0 as \"id\", " +
                                                  "'' as \"name\" " +
                                            "UNION " +
                                           "SELECT id as \"id\", " +
                                             "name as \"name\"" +
                                             "FROM position; ";

        static public string sqlAcademicDegree = "SELECT 0 as \"id\", " +
                                                        "'' as \"name\" " +
                                                  "UNION " +
                                                 "SELECT id as \"id\", " +
                                                   "name as \"name\"" +
                                                   "FROM academic_degree; ";
    }
}
