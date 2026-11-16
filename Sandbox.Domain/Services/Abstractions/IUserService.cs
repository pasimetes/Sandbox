using System;

namespace Sandbox.Domain;

public interface IUserService
{
    Task<List<User>> GetUsers(CancellationToken cancellationToken);
}0