using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DestinosDePortugal.Models
{
    public class Administrador
    {
        public User SelectById(int id)
        {
           

            User user = new User();
            string query = "";
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString()))
            {
                query = "Select * from Users where id=@id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        //teste
                        user.UserName = oReader["Username"].ToString();
                        user.Email = oReader["Email"].ToString();
                        //user.RegDate = Convert.ToDateTime(oReader["local"]);
                    }
                    connection.Close();
                }
            }
            return user;
        }
        public User CreateUser(string nome, string idade, string local, string type) {

            return null;
        }

        public User ChangeUserTypeByid(int id, string type) {

            return null;
        }
        public User DeleteUserByid(int id) {

            return null;
        }



    }
}