using BKTrace.Helpers;
using BKTrace.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BKTrace.Services
{
    public interface IUserService
    {
        User authenticate(string username, string password);
        IEnumerable<User> getAll();
    }
    public class UserService : IUserService
    {
        private List<User> _users = new List<User>
        {
            new User{id = 1, user_name = "Quan", password = "quan"}
        };
        private readonly AppSettings _appSettings;

        public UserService(IOptions<AppSettings> appSetting)
        {
            _appSettings = appSetting.Value;
        }
        public User authenticate(string username, string password)
        {
            var user = _users.SingleOrDefault(x => x.user_name == username && x.password == password);
            if(user == null)
            {
                return null;
            }
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.token = tokenHandler.WriteToken(token);
            return user.WithoutPassword();

        }

        public IEnumerable<User> getAll()
        {
            return _users.withoutPasswords();
        }
    }
}
