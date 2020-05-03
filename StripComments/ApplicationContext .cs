using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace StripComments
{
    sealed class ApplicationContext : DbContext
    {
        public DbSet<InputText> InputTexts { get; set; }
        public DbSet<InputSymbol> InputSymbols { get; set; }
        public DbSet<ToStrip> ToStrips { get; set; }
        public DbSet<Output> Outputs { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=StripComment;Trusted_Connection=True;");
        }
    }
}
