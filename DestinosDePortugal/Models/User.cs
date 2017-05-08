using System;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DestinosDePortugal.Models
{
    public class User
    {

        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember on this computer")]
        public bool RememberMe { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Date de Registo")]
        public DateTime? RegDate { get; set; }

        public bool IsValid(string _username, string _password)
        {
            using (var cn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString()))
            {
                string _sql = @"SELECT [Username] FROM [dbo].[Users] " +
                       @"WHERE [Username] = @u AND [Password] = @p";
                var cmd = new SqlCommand(_sql, cn);
                cmd.Parameters
                    .Add(new SqlParameter("@u", SqlDbType.NVarChar))
                    .Value = _username;
                cmd.Parameters
                    .Add(new SqlParameter("@p", SqlDbType.NVarChar))
                     .Value = Helpers.SHA1_Encode(_password);
                
                cn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Dispose();
                    cmd.Dispose();
                    return true;
                }
                else
                {
                    reader.Dispose();
                    cmd.Dispose();
                    return false;
                }
            }
        }
    }
}