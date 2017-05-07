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
        public string type { get; set; }

        
    }
}