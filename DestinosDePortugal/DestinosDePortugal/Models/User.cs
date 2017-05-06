using System;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;

namespace DestinosDePortugal.Models
{
    public class Users
    {
    
        [Key]
        public int ID { get; set; }
        [Required]
        public string nome { get; set; }
        public int idade { get; set; }
        public string local { get; set; }

        public Users SelectById(int id) {
            var conn = ConfigurationManager.ConnectionStrings["connection"].ToString();
              //  SqlConnection("Server=DESKTOP-ATP05MJ\\SQLSERVER;Database=DestPTdb;Trusted_Connection=Yes;");

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
                        user.idade = Convert.ToInt32(oReader["idade"]);
                        user.nome = oReader["nome"].ToString();
                        user.local = oReader["local"].ToString();
                    }
                    connection.Close();
                }
            }
            return user;
                
        

        }
    }
}