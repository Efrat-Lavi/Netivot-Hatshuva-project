using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Core.Interfaces
{
    public interface IRepository<T>
    {
        //List<T> GetAll();
        T GetById(int id);
        bool Add(T t);
        bool Update(int id, T t);
        bool Delete(int id);
    }
}
