using Netivot.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Core.Interfaces.IServices
{
    public interface IAvrechService
    {
        List<AvrechEntity> GetAllAvrechim();
        AvrechEntity GetAvrechById(int id);
        bool AddAvrech(AvrechEntity t);
        bool UpdateAvrech(int id, AvrechEntity t);
        bool DeleteAvrech(int id);
        //AvrechEntity GetAvrechByName(string firstName);

    }
}
