using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RoleRepository : IRoleRepository
    {
        public void AddRole(Role role) => RoleDAO.AddRole(role);
        public void DeleteRole(Role role) => RoleDAO.DeleteRole(role);
        public Role GetRoleById(int id) => RoleDAO.FindRoleById(id);
        public List<Role> GetRoles() => RoleDAO.GetRoles();
        public void UpdateRole(Role role) => RoleDAO.UpdateRole(role);
    }
}
