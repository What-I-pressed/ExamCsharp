using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Xml.Linq;
using _13.SimleForm.Helpers;

namespace _13.SimleForm.Services
{
    public class TableManager
    {
        private readonly SqlConnection _con;
        public TableManager(string databaseName)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            string host = configuration.GetConnectionString("Host");
            string user = configuration.GetConnectionString("User");
            string password = configuration.GetConnectionString("Password");
            string conStr = $"Data Source={host};User ID={user};Password={password};" +
                $"MultipleActiveResultSets=true;";
            conStr += $"Initial Catalog={databaseName};";
            try
            {
                _con = new SqlConnection(conStr);
                _con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка підключення!!! " + ex.Message);
            }
        }

        public SqlConnection GetSqlConnection() { return _con; }

        public List<string> GetTablesList()
        {
            List<string> tabels = new List<string>();
            //показати список БД
            string sql = "SELECT name FROM sys.tables";
            SqlCommand sqlCommand = _con.CreateCommand();
            sqlCommand.CommandText = sql;
            //Результа сервера будемо читати через SqlDataReeader
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    tabels.Add((string)reader["name"]);
                }
            }
            return tabels;
        }

        public void AddCategoryTable()
        {
            string[] tables = { "tblCategories" };
            foreach (string table in tables)
            {
                string path = Path.Combine("C:\\Users\\Антон\\source\\repos\\Exa\\ExampleProject\\13.SimleForm", "SqlQuery", $"{table}.sql");
                string query = File.ReadAllText(path);
                SqlCommand sqlCommand = _con.CreateCommand(); //окманди виконуєються на основі підлкючення
                sqlCommand.CommandText = query; //текст команди
                                                //виконати комнаду до сервера
                sqlCommand.ExecuteNonQuery();
            }
        }
    }


}
