using LMS.BLL.Interface;
using LMS.BLL.Model;
using LMS.BLL.Repository;
using LMS.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BLL.Service
{
    public class UserInRoleService : GenericRepository<UserInRole>, IUserInRoleService
    {
        
        GenericRepository<UserInRole> _userInRole = new GenericRepository<UserInRole>();

        public List<UserInRoleDTO> GetAllUsers()
        {
            var listOfUsers = _userInRole.GetAll();

            var listOfUserInRoleDTO = new List<UserInRoleDTO>();

            //Map from (List<UsersInRole>) to (List<UserInRoleDTO>)
            foreach (var item in listOfUsers)
            {
                var userInRoleDTO = new UserInRoleDTO()
                {
                    Id = item.Id,
                    Name = item.Name,
                    CreatedOn = item.CreatedOn,
                    IsActive = item.IsActive,
                    RoleId = item.RoleId,
                };
                listOfUserInRoleDTO.Add(userInRoleDTO);
            }

            return listOfUserInRoleDTO;
        }

        public UserInRoleDTO GetUserById(int id)
        {
            var user = _userInRole.GetBy(id);

            //Map from (List<UserInRole>) to (List<UserInRoleDTO>)

            var userInRoleDTO = new UserInRoleDTO()
            {
                Id = user.Id,
                Name = user.Name,
                CreatedOn = user.CreatedOn,
                IsActive = user.IsActive,
                RoleId= user.RoleId,
            };

            return userInRoleDTO;
        }
        public void CreateUser(UserInRoleDTO model)
        {
            //Map from (UserInRoleDTO) to (UserInRole)

            var userInRole = new UserInRole()
            {
                Id= model.Id,
                Name = model.Name,  
                RoleId = model.RoleId,
                CreatedOn = model.CreatedOn,
                IsActive = model.IsActive
            };
            _userInRole.Create(userInRole);
        }
        public void UpdateUser(UserInRoleDTO model)
        {
            //Map from (UserInRoleDTO) to (UserInRole)

            var userInRole = new UserInRole()
            {
                Id = model.Id,
                Name = model.Name,
                CreatedOn = model.CreatedOn,
                IsActive = model.IsActive,
                RoleId = model.RoleId
            };
            _userInRole.Update(userInRole);
        }
        public void DeleteUser(UserInRoleDTO model)
        {
            //Map from (CategoryDTO) to (Category)

            var userInRole = new UserInRole()
            {
                Id = model.Id,
                Name = model.Name,
                CreatedOn = model.CreatedOn,
                IsActive = model.IsActive,
                RoleId = model.RoleId
            };
            _userInRole.Update(userInRole);
        }
    }
}
