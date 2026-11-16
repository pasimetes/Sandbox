using System;
using Sandbox.Application;

namespace Sandbox.Infrastructure;

public class CurrentApiUser(IHttpContextAccessor httpContextAccessor)
    : ICurrentUser
{
    public int Id { get; }

    public int Role { get; }

    public string Username { get; }
    
    public string LanguageTwoLetterIsoCode { get; }
}