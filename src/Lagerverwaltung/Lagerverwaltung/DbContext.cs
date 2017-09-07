namespace Lagerverwaltung
{
    public class DbContextLager : System.Data.Entity.DbContext
    {
        public DbContextLager() : base("DefaultConnection")
        {
        }

        public static DbContextLager Create()
        {
            return new DbContextLager();
        }

        public System.Data.Entity.DbSet<Produkt> Products { get; set; }
        public System.Data.Entity.DbSet<Category> Categories { get; set; }
    }
}
