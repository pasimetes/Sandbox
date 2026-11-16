using System;
using Microsoft.EntityFrameworkCore;
using Sandbox.Domain;

namespace Sandbox.Application;

public interface IApplicationDbContext
{
    DbSet<User> Users  { get; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}