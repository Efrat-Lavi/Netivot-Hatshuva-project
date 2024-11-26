using Netivot.Core.Entities;
using Netivot.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Service
{
    public class DonorServices:IService<DonorEntity>
    {
        readonly IRepository<DonorEntity> _iRepository;
        public DonorServices(IRepository<DonorEntity> iRepository)
        {
            _iRepository = iRepository;
        }
        public List<DonorEntity> GetAll()
        {
            return _iRepository.GetAll();
        }
        public DonorEntity GetById(int id)
        {
            return _iRepository.GetById(id);

        }
        public bool Add(DonorEntity donor)
        {
            return _iRepository.Add(donor);

        }
        public bool Update(int id, DonorEntity donor)
        {
            return _iRepository.Update(id, donor);

        }
        public bool Delete(int id)
        {
            return _iRepository.Delete(id);

        }
        public DonorEntity GetByName(string firstName)
        {
            return _iRepository.GetByName(firstName);

        }
    }
}
