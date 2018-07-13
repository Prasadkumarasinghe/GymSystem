using SolidProject.Entities.Models;
using SolidProject.Entities.Repository.Implementation;
using SolidProject.Entities.Repository.Interface;
using SolidProject.Service.DTO;
using SolidProject.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidProject.Service.Implementation
{
    public class MembersService : IMembersService
    {
        IUnitOfWork _IUnitOfWork = new UnitOfWork(new Entities.SolidModel());

        public int NewMember(MembersDTO model)
        {
            Members membersModel = new Members();
            membersModel.FName = model.FName;
            _IUnitOfWork.Members.Add(membersModel);
            return _IUnitOfWork.Commit();
        }
    }
}
