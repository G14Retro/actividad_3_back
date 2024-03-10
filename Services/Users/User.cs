using actividad_3_back.Context;
using actividad_3_back.Models.DAO;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace actividad_3_back.Services.Users
{
    public class User : IUsers
    {
        #region Private Fields
        private readonly AppDbContext _appDbContext;
        private readonly string _secretKey;
        #endregion

        public User(AppDbContext appDbContext, IConfiguration configuration)
        {
            _appDbContext = appDbContext;
            _secretKey = configuration.GetSection("settings").GetSection("secretKey").ToString();
        }

        public async Task<UserModel> CreateUser(UserModel user)
        {
            await _appDbContext.Users.AddAsync(user);
            await _appDbContext.SaveChangesAsync();
            return await Task.FromResult(user);
        }

        public Task<UserModel> DeleteUser(UserModel user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserModel>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> GetUsersById(Guid idUser)
        {
            throw new NotImplementedException();
        }

        public async Task<string> LoginUser(string email, string password)
        {
            var user = await _appDbContext.Users.FirstAsync(x=> x.Email.Equals(email) && x.Password.Equals(password));
            if (user == null)
            {
                return "Usuario o contraseña incorrectos";
            }

            var keyBytes = Encoding.ASCII.GetBytes(_secretKey);
            var claims = new ClaimsIdentity();

            claims.AddClaim(new Claim(ClaimTypes.NameIdentifier, email));
            claims.AddClaim(new Claim(ClaimTypes.Role, "admin"));

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = claims,
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(keyBytes),SecurityAlgorithms.HmacSha256Signature),
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenConfig = tokenHandler.CreateToken(tokenDescriptor);

            string token = tokenHandler.WriteToken(tokenConfig);

            return token;
        }

        public Task<UserModel> UpdateUser(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}
