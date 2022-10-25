using PostgresWebApi.Data;
using PostgresWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace PostgresWebApi.Services
{
    public class UserService
    {
        private readonly DatabaseContext _context;

        public UserService(DatabaseContext context)
        {
            _context = context;
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.AsNoTracking().ToList();
        }

        public User GetUserById(int id)
        {
            var user = _context.Users.Find(id);

            if (user is null)
            {
                throw new InvalidOperationException("User does not exists");
            }

            return user;
        }

        public User CreateNewUser(User user)
        {
            int userId = 1;
            var lastUser = _context.Users.OrderBy(users => users.Id).LastOrDefault();
            if (lastUser is not null)
            {
                userId = lastUser.Id + 1;
            }

            user.Id = userId;
            _context.Users.Add(user);
            _context.SaveChanges();

            return user;
        }

        public void UpdateUser(User user)
        {
            var userToUpdate = _context.Users.Find(user.Id);
            if (userToUpdate is null)
            {
                throw new InvalidOperationException("User does not exist");
            }

            userToUpdate.Name = user.Name;
            userToUpdate.Lastname = user.Lastname;
            userToUpdate.Email = user.Email;
            userToUpdate.Position = user.Position;
            userToUpdate.Age = user.Age;

            _context.Users.Update(userToUpdate);
            _context.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user is null)
            {
                throw new InvalidOperationException("User does not exists");
            }

            _context.Users.Remove(user);
            _context.SaveChanges();
        }

    }
}