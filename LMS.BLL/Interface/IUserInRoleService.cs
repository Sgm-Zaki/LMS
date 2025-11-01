using LMS.BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BLL.Interface
{
    public interface IUserInRoleService
    {
        public List<UserInRoleDTO> GetAllUsers();
        public UserInRoleDTO GetUserById(int id);

        public void CreateUser(UserInRoleDTO model);
        public void UpdateUser(UserInRoleDTO model);
        public void DeleteUser(UserInRoleDTO model);
    }
}
