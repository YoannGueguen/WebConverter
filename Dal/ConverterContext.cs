
using DomainModel;
using Microsoft.EntityFrameworkCore;

namespace Dal
{
    public class ConverterContext : DbContext
    {
        public DbSet<Converter> Converters { get; set; }


        public ConverterContext()
            : base()
        {
        }

        public ConverterContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //For ConsoleApp Only
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
            Initial Catalog=ConvertDb;Integrated Security=True;
            MultipleActiveResultSets=True;");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
