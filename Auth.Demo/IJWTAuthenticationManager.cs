namespace Auth.Demo
{
    public interface IJWTAuthenticationManager
    {
        string Authenticate(string username, string password);

    }
}
