using MiniCRM.Data;
using MiniCRM.Models;
using System.Linq;

namespace MiniCRM.Services
{
    public class AuthService
    {
        public User? Login(string username, string password)
        {
            using var db = new AppDbContext();

            var user = db.Users
                .FirstOrDefault(u => u.Username == username && u.Password == password && u.IsActive);

            return user;
        }
    }
}