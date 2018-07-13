using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidProject.Entities.Repository.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IMemberRepo Members { get; }
        int Commit();
    }
}
