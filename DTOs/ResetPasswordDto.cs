namespace auth_system_be.DTOs
{
    public class ResetPasswordDto
    {
        public string Email { get; set; }

        public string NewPassword { get; set; }
    }
}