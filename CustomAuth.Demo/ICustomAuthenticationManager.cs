using System.Collections.Generic;

namespace CustomAuth.Demo
{
    public interface ICustomAuthenticationManager
    {
        Dictionary<string, string> Tokens { get; }

        string Authenticate(string userName, string password);
    }
}
