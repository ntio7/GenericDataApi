namespace Generic.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Generic.Data.Models;

using System;

public class GenericDbContext : DbContext
{
    public GenericDbContext(DbContextOptions<GenericDbContext> options) : base(options)
    {

    }
    public DbSet<RequestAction> Actions => Set<RequestAction>();
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       modelBuilder.ApplyConfigurationsFromAssembly(typeof(RequestAction).Assembly);
    }
}

class GenericContextFactory : IDesignTimeDbContextFactory<GenericDbContext>
{
    public GenericDbContext CreateDbContext(string[]? args = null)
    {
        var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        var optionsBuilder = new DbContextOptionsBuilder<GenericDbContext>();
        optionsBuilder
            .UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);

        return new GenericDbContext(optionsBuilder.Options);
        //
    }
}

