
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Generic.Data.Models;


namespace Generic.Data
{
    public class GenericDbContext : DbContext
    {
        public GenericDbContext(DbContextOptions<GenericDbContext> options) : base(options)
        {

        }

        public DbSet<ActionAdapter> ActionAdapters => Set<ActionAdapter>();
        public DbSet<ActionHeader> ActionHeaders => Set<ActionHeader>();
        public DbSet<ActionType> ActionTypes => Set<ActionType>();
        public DbSet<RequestAction> Actions => Set<RequestAction>();
        public DbSet<RequestType> RequestTypes => Set<RequestType>();
        public DbSet<Item> Items => Set<Item>();
        public DbSet<ItemKey> ItemKeys => Set<ItemKey>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ActionAdapter).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ActionHeader).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ActionType).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RequestAction).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RequestType).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Item).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ItemKey).Assembly);
        }
    }

    public class GenericContextFactory : IDesignTimeDbContextFactory<GenericDbContext>
    {
        public GenericDbContext CreateDbContext(string[]? args = null)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            var optionsBuilder = new DbContextOptionsBuilder<GenericDbContext>();

            optionsBuilder
                .UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);

            return new GenericDbContext(optionsBuilder.Options);
        }
    }

}