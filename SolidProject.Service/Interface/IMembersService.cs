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

        Task<List<MembersDTO>> ListoFMembersAsync();
        List<MembersDTO> ListoFMembers();
        Task<MembersDTO> GetMemberAsync(int id);

        (bool isSave, string message) NewMember(MembersDTO model);
        (bool isDeleted, string message) DeleteMember(int id);
        (bool isUpdated, string message) UpdateMember(MembersDTO model);

    }
}
