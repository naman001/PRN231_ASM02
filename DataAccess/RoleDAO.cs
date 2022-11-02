using BusinessObject;
using BusinessObject.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RoleDAO
    {
        public static List<Role> GetRoles()
        {
            var list = new List<Role>();
            try
            {
                using var context = new AppDbContext();
                list = context.Roles.ToList();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            return list;
        }
        public static Role FindRoleById(int id)
        {
            Role r = new();
            try
            {
                using var context = new AppDbContext();
                r = context.Roles.SingleOrDefault(x => x.role_id == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return r;
        }

        public static void AddRole(Role role)
        {
            try
            {
                using var context = new AppDbContext();
                context.Roles.Add(role);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void UpdateRole(Role role)
        {
            try
            {
                using var context = new AppDbContext();
                context.Entry<Role>(role).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void DeleteRole(Role role)
        {
            try
            {
                using var context = new AppDbContext();
                var rol = context.Roles.SingleOrDefault(c => c.role_id == role.role_id);
                context.Roles.Remove(rol);
                context.SaveChanges();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
