using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IUserRepository
    {
        void AddUser(User user);
        User GetUserById(int id);
        void UpdateUser(User user); 
        void DeleteUser(User user);
        List<User> GetUsers();
    }
}