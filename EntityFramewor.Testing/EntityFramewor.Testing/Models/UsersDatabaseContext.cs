using EntityFramewor.Testing.Configurations;
using Microsoft.EntityFrameworkCore;

namespace EntityFramewor.Testing.Models;

public partial class UsersDatabaseContext : DbContext
{
    public UsersDatabaseContext()
    {
    }

    public UsersDatabaseContext(DbContextOptions<UsersDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite(Configuration.DatabaseConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
