using Netivot.Core.Entities;
using Netivot.Core.Interfaces;
using Netivot.Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Service
{
    public class DonationServices:IDonationService
    {
        readonly IRepositoryManager _iRepository;
        public DonationServices(IRepositoryManager iRepository)
        {
            _iRepository = iRepository;
        }
        public List<DonationEntity> GetAllDonations()
        {
            return _iRepository._donationRepository.GetFull();
        }
        public DonationEntity GetDonationById(int id)
        {
            return _iRepository._donationRepository.GetById(id);

        }
        public bool AddDonation(DonationEntity donation)
        {
            bool succeed = _iRepository._donationRepository.Add(donation);
            if (succeed)
                _iRepository.save();
            return succeed;
        }
        public bool UpdateDonation(int id, DonationEntity donation)
        {
            bool succeed = _iRepository._donationRepository.Update(id, donation);
            if (succeed)
                _iRepository.save();
            return succeed;
        }
        public bool DeleteDonation(int id)
        {
            bool succeed = _iRepository._donationRepository.Delete(id);
            if (succeed)
                _iRepository.save();
            return succeed;
        }
        //public DonationEntity GetDonationByName(string firstName)
        //{
        //    return _iRepository.GetByName(firstName);

        //}
    }
}
