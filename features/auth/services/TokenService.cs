namespace SOA.features.auth.services
{
    public class TokenService
    {
        private readonly Random _random = new();

        public string get()
        {
            int code = _random.Next(0, 999999);
            return code.ToString("D6"); 
        }
    }
}
