using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Core.Interfaces
{
    public interface IRepository<T>
    {
        T GetById(int id);
        T Add(T t);
        T Update(int id, T t);
        bool Delete(int id);
    }
}
