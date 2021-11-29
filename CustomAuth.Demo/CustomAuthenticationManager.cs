using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomAuth.Demo
{
    public class CustomAuthenticationManager : ICustomAuthenticationManager
    {
        private readonly Dictionary<string, string> Users = new Dictionary<string, string>
        {
            { "test", "test"},
            { "custom", "custom"}
        };

        private readonly Dictionary<string, string> tokens = new Dictionary<string, string>();

        public Dictionary<string, string> Tokens => tokens;

        public string Authenticate(string userName, string password)
        {
            if (!Users.Any(u => u.Key == userName && u.Value == password))
            {
                return null;
            }

            var token = Guid.NewGuid().ToString();
            tokens.Add(token, userName);
            return token;
        }
    }
}
