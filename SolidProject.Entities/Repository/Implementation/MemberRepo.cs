using SolidProject.Entities.Models;
using SolidProject.Entities.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidProject.Entities.Repository.Implementation
{
    public class MemberRepo : Repository<Members> , IMemberRepo
    {
        public MemberRepo(SolidModel DbContext) : base(DbContext)
        {
        }
    }
}
