using System;
using Microsoft.EntityFrameworkCore;
using Sandbox.Domain;

namespace Sandbox.Application;

public class UserService(IApplicationDbContext appDb, ICurrentUser currentUser)
    : IUserService
{
    public async Task<List<User>> GetUsers(CancellationToken cancellationToken)
    {
        return await appDb.Users
            .AsNoTracking()
            .Where(u => u.Id != currentUser.Id)
            .ToListAsync(cancellationToken);
    }
}