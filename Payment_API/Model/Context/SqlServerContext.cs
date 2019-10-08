using Microsoft.EntityFrameworkCore;

namespace Payment_API.Model.Context
{
    public class SqlServerContext : DbContext
    {

        public SqlServerContext()
        {

        }

        public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options)
        {

        }

        public DbSet<Client> Client { get; set; }
        public DbSet<Buyer> Buyer { get; set; }
        public DbSet<Card> Card { get; set; }
        public DbSet<Payment> Payment { get; set; }


    }
}
