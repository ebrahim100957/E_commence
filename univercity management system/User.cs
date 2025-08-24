using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace univercity_management_system
{
    class User
    {
        static string myConn = Properties.Settings.Default.CRUD_DB;
        public string id { set; get; }
        public string userName { set; get; }
        public string password { set; get; }
        public string role { set; get; }

        private const string SelectQuery = "select Id as id , UserName as userName, Password as password,Role as role from Users ";

        private const string InsertQuery = "insert into users( UserName, Password,Role) values (@userName,@password,@role) ";

        private const string UpdateQuery = "update Users set UserName = @userName, Password = @password,Role = @role where Id = @id ";

        private const string DeleteQuery = "delete from Users where Id =@id ";

        public static DataTable GetUsers()
        {
            DataTable datatable = new DataTable();
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(SelectQuery, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(datatable);
                    }
                }
            }
            return datatable;
        }

        public bool InsertUser(User user)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                    
                    com.Parameters.AddWithValue("@userName", user.userName);
                    com.Parameters.AddWithValue("@password", user.password);
                    com.Parameters.AddWithValue("@role", user.role);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;

        }
        public bool UpdateUser(User user)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(UpdateQuery, con))
                {
                    com.Parameters.AddWithValue("@id", user.id);
                    com.Parameters.AddWithValue("@userName", user.userName);
                    com.Parameters.AddWithValue("@password", user.password);
                    com.Parameters.AddWithValue("@role", user.role);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;

        }
        public bool DeleteUser(User user)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(UpdateQuery, con))
                {
                    com.Parameters.AddWithValue("@id", user.id);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }


    }
    }

