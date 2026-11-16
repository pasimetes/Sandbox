using System;

namespace Sandbox.Domain;

public class User
{
    public int Id { get; init; }

    public string Username { get; init; }

    public byte[] Password { get; init; }

    public byte[] Salt { get; init; }

    public string Language { get; private set; }

    public void SetLanguage(string languageTwoLetterIsoCode)
    {

    }
}