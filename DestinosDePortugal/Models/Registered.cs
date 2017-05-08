using System.Configuration;
using System.Data.SqlClient;

namespace DestinosDePortugal.Models
{
    public class Registered
    {
        public Comments inserComment(string comment) {

            
            //var conn = ConfigurationManager.ConnectionStrings["connection"].ToString();

            //Comments comments = new Comments();
            //Users user = new Users();
            //string query = "";
            //using (SqlConnection connection = new SqlConnection(conn))
            //{


            //    query = "INSERT INTO tbl_comments values(...)";
            //    SqlCommand cmd = new SqlCommand(query, connection);
            //    cmd.Parameters.AddWithValue("@comment", comment);
            //    connection.Open();
            //    using (SqlDataReader oReader = cmd.ExecuteReader())
            //    {
            //        while (oReader.Read())
            //        {
            //            comments.userId = user.ID;
            //            comments.comment = comment;
            //            user.local = oReader["local"].ToString();
            //        }
            //        connection.Close();
            //    }
            //}
           

            return null;
        }

    }
}