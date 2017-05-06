using System.Data.Entity;

namespace DestinosDePortugal.Models
{
    public class DestPTdb : DbContext
    {
        public virtual DbSet<Users> Users { get; set; }

        public DestPTdb() : base("DestPTdb")
        {

        }
    }
}