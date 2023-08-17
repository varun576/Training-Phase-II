using JwtAuth.Exceptions;
using JwtAuth.Models;
using Microsoft.EntityFrameworkCore;

namespace JwtAuth.Services
{
    public class UserService : IUser
    {
        private PayodaStudentContext _context;

        public UserService(PayodaStudentContext context)
        {
            _context = context;
        }

        public async Task<List<User>> AddUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<User> GetUserByUsername(string username)
        {
            User? user = await _context.Users.FirstOrDefaultAsync(u => u.UserName.Equals(username));
            if(user == null) 
            {
                throw new Exception(UserExceptions.ExecptionMessages[1]);
            }
            return user;

        }

        public async Task<User> UpdateUser(string username, User user)
        {
            User? ruser = await _context.Users.FirstOrDefaultAsync(u => u.UserName.Equals(username));
            if (ruser == null)
            {
                throw new Exception(UserExceptions.ExecptionMessages[1]);
            }
            ruser.Password = user.Password;
            ruser.Role = user.Role;
            await _context.SaveChangesAsync();
            return ruser;
        }

        public async Task<List<User>> DeleteUser(string username)
        {
            User? ruser = await _context.Users.FirstOrDefaultAsync(u => u.UserName.Equals(username));
            if (ruser == null)
            {
                throw new Exception(UserExceptions.ExecptionMessages[1]);
            }
            _context.Users.Remove(ruser);
            _context.SaveChanges();
            return await _context.Users.ToListAsync();
        }

        public async Task<List<User>> GetAllUsers()
        {
            var response = await _context.Users.ToListAsync();
            if (response == null)
            {
                throw new Exception(UserExceptions.ExecptionMessages[0]);
            }
            return response;
        }
    }
}
