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
    public class MemberService : GenericRepository<Member>, IMemberService
    {

        GenericRepository<Member> _member = new GenericRepository<Member>();

        public List<MemberDTO> GetAllMembers()
        {
            var listOfMembers =  _member.GetAll();

            var listOfMemberDTO = new List<MemberDTO>();

            //Map from (List<Member>) to (List<MemberDTO>)
            foreach (var item in listOfMembers)
            {
                var memberDTO = new MemberDTO()
                {
                    Id = item.Id,
                    Name = item.Name,
                    CreatedOn = item.CreatedOn,
                    IsActive = item.IsActive,
                    Email = item.Email,
                    PhoneNumber = item.PhoneNumber,
                    MembershipDate = item.MembershipDate,
                };
                listOfMemberDTO.Add(memberDTO);
            }
            return listOfMemberDTO;
        }


        public MemberDTO GetMemberById(int id)
        {
            var member =  _member.GetBy(id);

            //Map from (List<Member>) to (List<MemberDTO>)

            var memberDTO = new MemberDTO()
            {
                Id = member.Id,
                Name = member.Name,
                CreatedOn = member.CreatedOn,
                IsActive = member.IsActive,
                Email = member.Email,
                PhoneNumber = member.PhoneNumber,
                MembershipDate = member.MembershipDate
            };

            return memberDTO;
        }


        public void CreateMember(MemberDTO model)
        {
            //Map from (MemberDTO) to (Member)

            var member = new Member()
            {
                Id= model.Id,
                Name = model.Name,
                CreatedOn= model.CreatedOn,
                IsActive = model.IsActive,  
                Email = model.Email,    
                PhoneNumber = model.PhoneNumber,
                MembershipDate = model.MembershipDate   
            };

           _member.Create(member);
            
        }

       

        public void UpdateMember(MemberDTO model)
        {
            //Map from (MemberDTO) to (Member)

            var member = new Member()
            {
                Id = model.Id,
                Name = model.Name,
                CreatedOn = model.CreatedOn,
                IsActive = model.IsActive,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                MembershipDate = model.MembershipDate
            };

           _member.Update(member);       
        }

        public void DeleteMember(MemberDTO model)
        {
            //Map from (MemberDTO) to (Member)

            var member = new Member()
            {
                Id = model.Id,
                Name = model.Name,
                CreatedOn = model.CreatedOn,
                IsActive = model.IsActive,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                MembershipDate = model.MembershipDate
            };

            _member.Delete(member);
        }
        //public async Task DeleteMemberAsync(MemberDTO model)
        //{
        //    //Map from (MemberDTO) to (Member)

        //    var member = new Member()
        //    {
        //        Id = model.Id,
        //        Name = model.Name,
        //        CreatedOn = model.CreatedOn,
        //        IsActive = model.IsActive,
        //        Email = model.Email,
        //        PhoneNumber = model.PhoneNumber,
        //        MembershipDate = model.MembershipDate
        //    };

        //    await _member.DeleteAsync(member);
        //}

    }
}
