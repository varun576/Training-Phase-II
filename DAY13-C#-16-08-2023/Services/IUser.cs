using JwtAuth.Models;

namespace JwtAuth.Services
{
    public interface IUser
    {
        Task<User> GetUserByUsername(string username);
        Task<List<User>> GetAllUsers();
        Task<List<User>> AddUser(User user);
        Task<User> UpdateUser(string username,User user);
        Task<List<User>> DeleteUser(string username);

    }
}
