using Microsoft.EntityFrameworkCore;

namespace StripComments
{
    sealed class ApplicationContext : DbContext
    {
        public DbSet<InputText> InputTexts { get; set; }
        public DbSet<InputSymbol> InputSymbols { get; set; }
        public DbSet<Output> Outputs { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=StripComment;Trusted_Connection=True;");
        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InputText>().HasData(
                new InputText[]
                {
                    new InputText {InputTextId = 1, Text = "apples, pears # and bananas\ngrapes\nbananas !apples"},
                    new InputText {InputTextId = 2, Text = "a #b\nc\nd $e f g"}, 
                    new InputText {InputTextId = 3, Text = "string1\nstring2%with symbols\nstring3 with some text ^  comments "}
                }
            );

            modelBuilder.Entity<InputSymbol>().HasData(
                new InputSymbol[]
                {
                    new InputSymbol {InputSymbolId = 1, Symbol = "[\"#\",\"!\"]"},
                    new InputSymbol {InputSymbolId = 2, Symbol = "[\"#\",\"$\"]"},
                    new InputSymbol {InputSymbolId = 3, Symbol = "[\"%\",\"^\"]"},
                }
            );


            modelBuilder.Entity<Output>().HasData(
                new Output[]
                {
                    new Output {OutputId = 1, OutputText = "apples, pears\ngrapes\nbananas"}, 
                    new Output {OutputId = 2, OutputText = "a\nc\nd"}, 
                    new Output {OutputId = 3, OutputText = "string1\nstring2\nstring3 with some text"}, 
                }
            );
        }
        
    }
}
