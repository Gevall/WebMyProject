using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using WebMyProject.UserAuth;

namespace WebMyProject
{
    public static class Program
    {
        /// <summary>
        /// Тестовые пользователя для проверки авторизации
        /// </summary>
        public static List<UserLogin> usersForTest = new List<UserLogin>
        {
            new UserLogin{email="test01@mail.ru", password="12345678"},
            new UserLogin{email="test02@mail.ru", password="12345678"}
        };

        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
            // Добавление контроллера c представлением
            builder.Services.AddControllersWithViews(); 
            // Добавление сервиса аутентификации методом Cookies
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(option =>
                option.LoginPath = "/Auth/Login");

            var app = builder.Build();

            // Дефолтный маршрут до начальный страницы
            app.MapControllerRoute(
                name: default,
                pattern: "{controller=Home}/{action=Index}");

            // Использование аутентификации
            app.UseAuthentication(); 
            // Использование авторизации
            app.UseAuthorization();

            app.Run();
        }
        

    }
}