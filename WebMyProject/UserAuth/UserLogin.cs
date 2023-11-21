using System.ComponentModel.DataAnnotations;

namespace WebMyProject.UserAuth
{
    public class UserLogin
    {
        // Email пользователя
        [Required]
        public string email { get; set; }

        // Пароль пользователя
        [Required, DataType(DataType.Password)]
        public string password { get; set; }

        public string? returnUrl { get; set; }
    }
}

