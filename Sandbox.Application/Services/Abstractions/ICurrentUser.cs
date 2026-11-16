using System;

namespace Sandbox.Application;

public interface ICurrentUser
{
    int Id { get; }
    
    string Username { get; }
    
    int Role { get; }
    
    string LanguageTwoLetterIsoCode { get; }
}