namespace BusExpress.Server.Helpers;

using Microsoft.EntityFrameworkCore;
using BusExpress.Shared.Entities;

public class DataContext : DbContext
{
    public DbSet<Account> Accounts { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}