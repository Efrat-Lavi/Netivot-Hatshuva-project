using Netivot.Core.Entities;
using Netivot.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Service
{
    public class DonationServices:IService<DonationEntity>
    {
        readonly IRepository<DonationEntity> _iRepository;
        public DonationServices(IRepository<DonationEntity> iRepository)
        {
            _iRepository = iRepository;
        }
        public List<DonationEntity> GetAll()
        {
            return _iRepository.GetAll();
        }
        public DonationEntity GetById(int id)
        {
            return _iRepository.GetById(id);

        }
        public bool Add(DonationEntity donation)
        {
            return _iRepository.Add(donation);

        }
        public bool Update(int id, DonationEntity donation)
        {
            return _iRepository.Update(id, donation);

        }
        public bool Delete(int id)
        {
            return _iRepository.Delete(id);

        }
        public DonationEntity GetByName(string firstName)
        {
            return _iRepository.GetByName(firstName);

        }
    }
}
