using System.Data.Entity;

namespace DAL
{
    public class SwitchContext : DbContext
    {
        public DbSet<Switch> Switches { get; set; }
    }
}
