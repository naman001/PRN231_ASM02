using BusinessObject;
using BusinessObject.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserDAO
    {
        public static List<User> GetUsers()
        {
            var list = new List<User>();
            try
            {
                using var context = new AppDbContext();
                list = context.Users.ToList();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            return list;
        }
        public static User FindUserById(int id)
        {
            User u = new();
            try
            {
                using var context = new AppDbContext();
                u = context.Users.SingleOrDefault(x => x.user_Id == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return u;
        }

        public static void AddUser(User user)
        {
            try
            {
                using var context = new AppDbContext();
                context.Users.Add(user);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void UpdateUser(User user)
        {
            try
            {
                using var context = new AppDbContext();
                context.Entry<User>(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void DeleteUser(User user)
        {
            try
            {
                using var context = new AppDbContext();
                var use = context.Users.SingleOrDefault(c => c.user_Id == user.user_Id);
                context.Users.Remove(use);
                context.SaveChanges();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
