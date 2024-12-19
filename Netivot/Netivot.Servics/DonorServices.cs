using Netivot.Core.Entities;
using Netivot.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Service
{
    public class DonorServices:IDonorService
    {
        readonly IRepository<DonorEntity> _iRepository;
        public DonorServices(IRepository<DonorEntity> iRepository)
        {
            _iRepository = iRepository;
        }
        public List<DonorEntity> GetAllDonors()
        {
            return _iRepository.GetAll();
        }
        public DonorEntity GetDonorById(int id)
        {
            return _iRepository.GetById(id);

        }
        public bool AddDonor(DonorEntity donor)
        {
            return _iRepository.Add(donor);

        }
        public bool UpdateDonor(int id, DonorEntity donor)
        {
            return _iRepository.Update(id, donor);

        }
        public bool DeleteDonor(int id)
        {
            return _iRepository.Delete(id);

        }
        public DonorEntity GetDonorByName(string firstName)
        {
            return _iRepository.GetByName(firstName);

        }
    }
}
