using System;
using Microsoft.EntityFrameworkCore;
using Sandbox.Application;
using Sandbox.Domain;

namespace Sandbox.Infrastructure;

public class AppDbContext(SqliteOptions sqlite) : DbContext,
    IApplicationDbContext
{
    public DbSet<User> Users { get; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(sqlite.ConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
    }
}