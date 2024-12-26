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
        List<DonationEntity> GetAllDonations();
        DonationEntity GetDonationById(int id);
        bool AddDonation(DonationEntity t);
        bool UpdateDonation(int id, DonationEntity t);
        bool DeleteDonation(int id);
        //DonationEntity GetDonationByName(string firstName);

    }
}
