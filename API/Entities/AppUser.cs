using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; } // byte[] is a byte array

        public byte[] PasswordSalt { get; set; }
    }
}