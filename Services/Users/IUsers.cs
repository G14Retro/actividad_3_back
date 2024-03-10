using actividad_3_back.Models.DAO;

namespace actividad_3_back.Services.Users
{
    public interface IUsers
    {
        Task<IEnumerable<UserModel>> GetAllUsers();
        Task<UserModel> CreateUser(UserModel user);
        Task<UserModel> UpdateUser(UserModel user);
        Task<UserModel> DeleteUser(UserModel user);
        Task<UserModel> GetUsersById(Guid idUser);
        Task <string> LoginUser(string email, string password);
    }
}
