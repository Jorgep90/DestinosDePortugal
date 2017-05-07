using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DestinosDePortugal.Models
{
    public class Administrador
    {
        public Users SelectById(int id)
        {
            var conn = ConfigurationManager.ConnectionStrings["connection"].ToString();

            Users user = new Users();
            string query = "";
            using (SqlConnection connection = new SqlConnection(conn))
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
                        user.idade = Convert.ToInt32(oReader["idade"]);
                        user.nome = oReader["nome"].ToString();
                        user.local = oReader["local"].ToString();
                    }
                    connection.Close();
                }
            }
            return user;
        }
        public Users CreateUser(string nome, string idade, string local, string type) {

            return null;
        }

        public Users ChangeUserTypeByid(int id, string type) {

            return null;
        }
        public Users DeleteUserByid(int id) {

            return null;
        }



    }
}