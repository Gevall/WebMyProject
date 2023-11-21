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
        /// �������� ������������ ��� �������� �����������
        /// </summary>
        public static List<UserLogin> usersForTest = new List<UserLogin>
        {
            new UserLogin{email="test01@mail.ru", password="12345678"},
            new UserLogin{email="test02@mail.ru", password="12345678"}
        };

        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
            // ���������� ����������� c ��������������
            builder.Services.AddControllersWithViews(); 
            // ���������� ������� �������������� ������� Cookies
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(option =>
                option.LoginPath = "/Auth/Login");

            var app = builder.Build();

            // ��������� ������� �� ��������� ��������
            app.MapControllerRoute(
                name: default,
                pattern: "{controller=Home}/{action=Index}");

            // ������������� ��������������
            app.UseAuthentication(); 
            // ������������� �����������
            app.UseAuthorization();

            app.Run();
        }
        

    }
}