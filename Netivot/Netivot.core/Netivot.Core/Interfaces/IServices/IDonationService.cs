using Netivot.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Core.Interfaces.IServices
{
    public interface IDonationService
    {
        IEnumerable<DonationDto> GetAllDonations();
        DonationDto GetDonationById(int id);
        DonationDto AddDonation(DonationDto t);
        DonationDto UpdateDonation(int id, DonationDto t);
        bool DeleteDonation(int id);
        //DonationEntity GetDonationByName(string firstName);

    }
}
