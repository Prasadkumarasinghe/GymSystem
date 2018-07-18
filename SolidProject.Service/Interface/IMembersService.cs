using SolidProject.Entities.Models;
using SolidProject.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidProject.Service.Interface
{
    public interface IMembersService
    {
        (bool isSave, string message) NewMember(MembersDTO model);
        Task<List<MembersDTO>> ListoFMembersAsync();
        List<MembersDTO> ListoFMembers();
    }
}
