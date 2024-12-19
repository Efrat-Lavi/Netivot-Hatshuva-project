using Netivot.Core.Entities;
using Netivot.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Service
{
    public class DonationServices:IDonationService
    {
        readonly IRepository<DonationEntity> _iRepository;
        public DonationServices(IRepository<DonationEntity> iRepository)
        {
            _iRepository = iRepository;
        }
        public List<DonationEntity> GetAllDonations()
        {
            return _iRepository.GetAll();
        }
        public DonationEntity GetDonationById(int id)
        {
            return _iRepository.GetById(id);

        }
        public bool AddDonation(DonationEntity donation)
        {
            return _iRepository.Add(donation);

        }
        public bool UpdateDonation(int id, DonationEntity donation)
        {
            return _iRepository.Update(id, donation);

        }
        public bool DeleteDonation(int id)
        {
            return _iRepository.Delete(id);

        }
        public DonationEntity GetDonationByName(string firstName)
        {
            return _iRepository.GetByName(firstName);

        }
    }
}
