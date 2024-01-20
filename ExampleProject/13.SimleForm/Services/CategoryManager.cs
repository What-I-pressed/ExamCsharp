using _13.SimleForm.Helpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.SimleForm.Services
{
    internal class CategoryManager
    {
        private readonly SqlConnection _con;

        public CategoryManager(SqlConnection con)
        {
            _con = con;
        }

        public string AddCategory(string Name, string Description, string url)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string sql = "INSERT INTO tblCategories " +
                "(Name, Description, [Image], CreatedDate) " +
                $"VALUES(@Name, @Description, @Image, @CreatedDate);";
            SqlCommand sqlCommand = _con.CreateCommand(); //окманди виконуєються на основі підлкючення
            sqlCommand.CommandText = sql; //текст команди

            // Create a parameter with NVarChar data type for Unicode strings and add it to the command's Parameters collection
            SqlParameter pName = new SqlParameter("@Name", System.Data.SqlDbType.NVarChar);
            pName.Value = Name;
            sqlCommand.Parameters.Add(pName);

            SqlParameter pDescription = new SqlParameter("@Description", System.Data.SqlDbType.NVarChar);
            pDescription.Value = Description;
            sqlCommand.Parameters.Add(pDescription);

            string imageName = ImageWorker.ImageSave(url);

            SqlParameter pImage = new SqlParameter("@Image", System.Data.SqlDbType.NVarChar);
            pImage.Value = imageName;
            sqlCommand.Parameters.Add(pImage);

            SqlParameter pCreatedDate = new SqlParameter("@CreatedDate", System.Data.SqlDbType.DateTime);
            pCreatedDate.Value = date;
            sqlCommand.Parameters.Add(pCreatedDate);

            //виконати комнаду до сервера
            sqlCommand.ExecuteNonQuery();
            return imageName;
        }

        public int GetFirstCategoryID()
        {
            string command = "SELECT TOP 1 Id FROM tblCategories ORDER BY Id ASC";
            SqlCommand sql = _con.CreateCommand();
            sql.CommandText = command;
            SqlDataReader sqlDataReader = sql.ExecuteReader();
            sqlDataReader.Read();
            return (int)sqlDataReader["Id"];

        }

        public Dictionary<string, string> GetCategory(int ID)
        {
            Dictionary<string, string> category = new Dictionary<string, string>();
            SqlCommand sqlCommand = _con.CreateCommand();
            string command = "Select Name, Description, [Image], CreatedDate From tblCategories " +
            $"Where Id = {ID}";
            sqlCommand.CommandText = command;
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                if(reader.Read())
                {
                    category.Add("Name", reader["Name"].ToString());
                    category.Add("Description", reader["Description"].ToString());
                    category.Add("Image", reader["Image"].ToString());
                    category.Add("CreatedDate", reader["CreatedDate"].ToString());
                    return category;
                }
                return null;
            }
        }
    }
}
