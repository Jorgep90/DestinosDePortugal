using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DestinosDePortugal.Models
{
    public class Comments
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int userId { get; set; }
        public string comment { get; set; }       
        public DateTime? data { get; set; }
    }
}