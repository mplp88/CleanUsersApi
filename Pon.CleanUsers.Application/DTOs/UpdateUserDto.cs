using System.ComponentModel.DataAnnotations;

namespace Pon.CleanUsers.Application.DTOs
{
    public class UpdateUserDto
    {
        [Required, MinLength(2)]
        public string FirstName { get; set; } = default!;

        [Required, MinLength(2)]
        public string LastName { get; set; } = default!;

        [Required, EmailAddress]
        public string Email { get; set; } = default!;
    }
}

