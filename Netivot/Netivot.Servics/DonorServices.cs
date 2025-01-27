using AutoMapper;
using Netivot.Core.Entities;
using Netivot.Core.Interfaces;
using Netivot.Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Service
{
    public class DonorServices:IDonorService
    {
        readonly IRepositoryManager _iRepository;
        private readonly IMapper _mapper;

        public DonorServices(IRepositoryManager iRepository, IMapper mapper)
        {
            _iRepository = iRepository;
            _mapper = mapper;
        }
        public IEnumerable<DonorDto> GetAllDonors()
        {
            var donors = _iRepository._donorRepository.GetFull();
            var donorsDto = _mapper.Map<IEnumerable<DonorDto>>(donors);
            return donorsDto;
        }
        public DonorDto GetDonorById(int id)
        {
            var donor = _iRepository._donorRepository.GetById(id);
            var donorDto = _mapper.Map<DonorDto>(donor);
            return donorDto;

        }
        public DonorDto AddDonor(DonorDto donorDto)
        {
            var donor = _mapper.Map<DonorEntity>(donorDto);
            donor = _iRepository._donorRepository.Add(donor);
            if (donor != null)
            {
                _iRepository.save();
                return donorDto;
            }
            return null;
        }
        public DonorDto UpdateDonor(int id, DonorDto donorDto)
        {
            var donor = _mapper.Map<DonorEntity>(donorDto);
            donor = _iRepository._donorRepository.Update(id,donor);
            if (donor != null)
            {
                _iRepository.save();
                return donorDto;
            }
            return null;
        }

        public bool DeleteDonor(int id)
        {
            bool succeed = _iRepository._donorRepository.Delete(id);
            if (succeed)
                _iRepository.save();
            return succeed;
        }
        //public DonorEntity GetDonorByName(string firstName)
        //{
        //    return _iRepository.GetByName(firstName);

        //}
    }
}
