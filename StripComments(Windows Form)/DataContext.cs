using System.Data.Entity;

namespace StripComments_Windows_Form_
{
    class DataContext : DbContext
    {
        public DataContext()
            : base("DefaultConnection")
        {
            //Database.SetInitializer(new DataInitializer());
        }

        public DbSet<Data> Datas { get; set; }
    }
}
