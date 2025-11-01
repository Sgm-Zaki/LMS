using LMS.BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BLL.Interface
{
    public interface IMemberService
    {
        public List<MemberDTO> GetAllMembers();
        public MemberDTO GetMemberById(int id);

        public void CreateMember(MemberDTO model);
        public void UpdateMember(MemberDTO model);
        public void DeleteMember(MemberDTO model);
        
    }
}
