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
        public DonorServices(IRepositoryManager repository)
        {
            _iRepository = repository;
        }
        public List<DonorEntity> GetAllDonors()
        {
            return _iRepository._donorRepository.GetFull();
        }
        public DonorEntity GetDonorById(int id)
        {
            return _iRepository._donorRepository.GetById(id);

        }
        public bool AddDonor(DonorEntity donor)
        {
            bool succeed = _iRepository._donorRepository.Add(donor);
            if (succeed)
                _iRepository.save();
            return succeed;

        }
        public bool UpdateDonor(int id, DonorEntity donor)
        {
            bool succeed = _iRepository._donorRepository.Update(id,donor);
            if (succeed)
                _iRepository.save();
            return succeed;
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
