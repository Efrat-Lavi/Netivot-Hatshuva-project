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
        IEnumerable<DonorDto> GetAllDonors();
        DonorDto GetDonorById(int id);
        DonorDto AddDonor(DonorDto t);
        DonorDto UpdateDonor(int id, DonorDto t);
        bool DeleteDonor(int id);
        //DonorEntity GetDonorByName(string firstName);

    }
}
