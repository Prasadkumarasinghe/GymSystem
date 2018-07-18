using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using SolidProject.Entities.Models;
using SolidProject.Service.DTO;

namespace SolidProject.App_Start
{
    public static class AutoMapperConfig
    {
        public static void Config()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap< Members, MembersDTO>();
                cfg.CreateMap<MembersDTO,Members>();
            });           
        }
    }

}