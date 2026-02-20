using System.ComponentModel.DataAnnotations;

namespace SafeVault.Models
{
    public class UserAccount
    {
        public int Id { get; set; }

        [StringLength(50)]
        public required string Username { get; set; }

        [StringLength(100)]
        public required string Password { get; set; }

        public required string Role { get; set; }
    }
}

