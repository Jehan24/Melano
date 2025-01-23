using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DSAact1
{
    public class data
    {
        static string connectionString
        = "Data Source = DESKTOP-GKM4C71; Initial Catalog = dsaDB; Integrated Security = True;"; //Local Connection
        //= "Server=tcp:4.193.106.92,1433;Database=PUPHubPoints;User Id=sa;Password=PUPHUB123!;"; //Server Connection
        static SqlConnection sqlConnection;


        public data()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public List<Info> GetInfo()
        {
            var selectStatement = "SELECT * FROM info";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            var info = new List<Info>();

            while (reader.Read())
            {
                info.Add(new Info
                {
                    Name = reader["Name"].ToString(),
                    Course = reader["Course"].ToString(),
                    Age = Convert.ToInt32(reader["Age"].ToString()),
                });
            }

            sqlConnection.Close();
            return info;
        }
        public List<Info> GetInfo2()
        {
            var selectStatement = "SELECT * FROM Info";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            var info = new List<Info>();

            while (reader.Read())
            {
                info.Add(new Info
                {
                    Name = reader["Name"].ToString(),
                    Course = reader["Course"].ToString(),
                    Age = Convert.ToInt32(reader["Age"].ToString()),
                });
            }

            sqlConnection.Close();
            return info;
        }
    }
}


