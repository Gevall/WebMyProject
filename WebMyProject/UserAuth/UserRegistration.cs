using System.ComponentModel.DataAnnotations;

namespace WebMyProject.UserAuth
{
    public class UserRegistration
    {
        // email Пользователя
        [Required]
        public string email {  get; set; }

        // Пароль пользователя
        [Required, DataType(DataType.Password)]
        public string password { get; set; }

        // ПОдтврждение пароля
        [Required, DataType(DataType.Password), Compare(nameof(password))]
        public string confirmPassword { get; set; }
    }
}
