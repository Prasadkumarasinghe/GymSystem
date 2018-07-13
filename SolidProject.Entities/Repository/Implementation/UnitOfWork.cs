using SolidProject.Entities.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidProject.Entities.Repository.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private SolidModel DbContext;

        public UnitOfWork(SolidModel DbContext)
        {
            this.DbContext = DbContext;
            Members = new MemberRepo(this.DbContext);
        }

        public IMemberRepo Members { get; private set; }

        public int Commit()
        {
           return DbContext.SaveChanges();
        }

        public void Dispose()
        {
            DbContext.Dispose();
        }
    }
}
