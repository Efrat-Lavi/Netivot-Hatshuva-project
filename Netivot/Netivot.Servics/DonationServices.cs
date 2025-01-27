using AutoMapper;
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
        private readonly IMapper _mapper;

        public DonationServices(IRepositoryManager iRepository, IMapper mapper)
        {
            _iRepository = iRepository;
            _mapper = mapper;
        }
        public IEnumerable<DonationDto> GetAllDonations()
        {
            var donations = _iRepository._donationRepository.GetFull();
            var donationsDto = _mapper.Map<IEnumerable<DonationDto>>(donations);
            return donationsDto;
        }
        public DonationDto GetDonationById(int id)
        {
            var donation = _iRepository._donationRepository.GetById(id);
            var donationDto = _mapper.Map<DonationDto>(donation);   
            return donationDto;

        }
        public DonationDto AddDonation(DonationDto donationDto)
        {
            var donation = _mapper.Map<DonationEntity>(donationDto);
            donation = _iRepository._donationRepository.Add(donation);
            if (donation != null)
            {
                _iRepository.save();
                return donationDto;
            }
            return null;
        }
        public DonationDto UpdateDonation(int id, DonationDto donationDto)
        {
            var donation = _mapper.Map<DonationEntity>(donationDto);
            donation = _iRepository._donationRepository.Update(id, donation);
            if (donation != null)
            {
                _iRepository.save();
                return donationDto;
            }
            return null;
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
