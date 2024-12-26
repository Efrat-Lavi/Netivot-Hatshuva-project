using Netivot.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Core.Interfaces.IServices
{
    public interface IDonorService
    {
        List<DonorEntity> GetAllDonors();
        DonorEntity GetDonorById(int id);
        bool AddDonor(DonorEntity t);
        bool UpdateDonor(int id, DonorEntity t);
        bool DeleteDonor(int id);
        //DonorEntity GetDonorByName(string firstName);

    }
}
