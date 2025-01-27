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
        IEnumerable<AvrechDto> GetAllAvrechim();
        AvrechDto GetAvrechById(int id);
        AvrechDto AddAvrech(AvrechDto t);
        AvrechDto UpdateAvrech(int id, AvrechDto t);
        bool DeleteAvrech(int id);
        //AvrechEntity GetAvrechByName(string firstName);

    }
}
