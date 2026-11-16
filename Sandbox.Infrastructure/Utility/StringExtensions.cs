using System;

namespace Sandbox.Infrastructure;

public static class StringExtensions
{
    public static int ToInt(this string text)
    {
        return int.Parse(text);
    }
    
    public static DateTime ToDateTime(this string text)
    {
        return DateTime.Parse(text);
    }
}