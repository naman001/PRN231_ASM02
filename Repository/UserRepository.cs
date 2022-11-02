using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository : IUserRepository
    {
        public void AddUser(User user) => UserDAO.AddUser(user);
        public void DeleteUser(User user) => UserDAO.DeleteUser(user);
        public User GetUserById(int id) => UserDAO.FindUserById(id);
        public List<User> GetUsers() => UserDAO.GetUsers();
        public void UpdateUser(User user) => UserDAO.UpdateUser(user);
    }
}
