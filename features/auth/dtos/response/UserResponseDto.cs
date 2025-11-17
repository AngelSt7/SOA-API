namespace SOA.features.auth.dtos.response
{
    public class UserResponseDto
    {
        public string Name { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public bool Confirmed { get; set; }
    }

}
