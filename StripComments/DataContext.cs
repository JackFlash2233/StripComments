using ClassLibrary;
using Microsoft.EntityFrameworkCore;

namespace StripComments
{
    sealed class DataContext : DbContext
    {
        public DbSet<Data> Datas { get; set; }

        public DataContext()
        {
           Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=StripComments;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Data>().HasData(
                new Data[]
                {
                    new Data
                    {
                        DataId = 1,
                        InputText = "apples, pears # and bananas\ngrapes\nbananas !apples", 
                        CommentSymbol = "# !",
                        OutputText = "apples, pears\ngrapes\nbananas"
                    },
                    new Data 
                    {
                        DataId = 2,
                        InputText = "a #b\nc\nd $e f g", 
                        CommentSymbol = "# $", 
                        OutputText = "a\nc\nd"
                    },
                    new Data
                    {
                        DataId = 3,
                        InputText = "string1\nstring2%with symbols\nstring3 with some text ^  comments ",
                        CommentSymbol = "% ^", 
                        OutputText = "string1\nstring2\nstring3 with some text"
                    },
                }
            );
        }
    }
}