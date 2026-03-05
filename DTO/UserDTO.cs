using System;

namespace DTO
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string? Role { get; set; }
        public string Password { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public DateTime? Birthday { get; set; }

        public string? Address { get; set; }
        public DateTime? CreatedAt { get; set; }
    }

}
