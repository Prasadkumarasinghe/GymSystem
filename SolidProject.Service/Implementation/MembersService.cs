using AutoMapper;
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

        IUnitOfWork _IUnitOfWork;
        IMapper _IMapper;

        //Dependency Injection Iunit of work
        public MembersService(IUnitOfWork IUnitOfWork)
        {
            _IUnitOfWork = IUnitOfWork;
            ConfigAutoMapper();
        }

        //Save Member
        public (bool isSave, string message) NewMember(MembersDTO model)
        {
            try
            {
                var modelData = _IMapper.Map<MembersDTO, Members>(model);
                _IUnitOfWork.Members.Add(modelData);
                var result = _IUnitOfWork.Commit();//Save to Database
                if (result > 0)
                    return (true, "Member added Successfuly");
                else
                    return (false, "Failed adding Member");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        //Get All the Members from the DataBase Asynchronously
        public async Task<List<MembersDTO>> ListoFMembersAsync()
        {
            var allMembers = await _IUnitOfWork.Members.GetAllAsync();
            var listResult = allMembers != null ? allMembers.ToList() : new List<Members>(); ;
            var destination = _IMapper.Map<List<Members>, List<MembersDTO>>(listResult);
            return destination;
        }

        //Get All the Members from the DataBase without Asynchronously
        public List<MembersDTO> ListoFMembers()
        {
            var allMembers = _IUnitOfWork.Members.GetAll();
            var listResult = allMembers != null ? allMembers.ToList() : new List<Members>(); ;
            var destination = _IMapper.Map<List<Members>, List<MembersDTO>>(listResult);
            return destination;
        }

        public void ConfigAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Members, MembersDTO>();
                cfg.CreateMap<MembersDTO, Members>();
            });
            _IMapper = config.CreateMapper();
        }

        public (bool isDeleted, string message) DeleteMember(int id)
        {
            var memberr = _IUnitOfWork.Members.Get(id);

            try
            {
                _IUnitOfWork.Members.Delete(memberr);
                _IUnitOfWork.Commit();
                return (true, "Member Deleted Successfully");
            }
            catch (Exception ex)
            {
                return (false, "Failed :"+ex.Message);
            }
          
        }

        public (bool isUpdated, string message) UpdateMember(MembersDTO model)
        {
            var modelData = _IMapper.Map<MembersDTO, Members>(model);
            _IUnitOfWork.Members.Update(modelData);
            var result = _IUnitOfWork.Commit();

            if (result > 0)
                return (true, "Member Updated Successfuly");
            else
                return (false, "Failed updating Member");
        }

        public async Task<MembersDTO> GetMemberAsync(int id)
        {
            var member=await _IUnitOfWork.Members.GetAsync(id);
            var modal = _IMapper.Map<Members, MembersDTO>(member);
            return modal;
        }
    }
}
