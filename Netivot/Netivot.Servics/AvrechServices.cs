using Netivot.Core.Entities;
using Netivot.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Service
{
    public class AvrechServices : IService<AvrechEntity>
    {
        readonly IRepository<AvrechEntity> _iRepository;
        public AvrechServices(IRepository<AvrechEntity> iRepository)
        {
            _iRepository = iRepository;
        }
        public List<AvrechEntity> GetAll()
        {
            return _iRepository.GetAll();
        }
        public AvrechEntity GetById(int id)
        {
            return _iRepository.GetById(id);

        }
        public bool Add(AvrechEntity avrech)
        {
            return _iRepository.Add(avrech);

        }
        public bool Update(int id, AvrechEntity avrech)
        {
            return _iRepository.Update(id, avrech);

        }
        public bool Delete(int id)
        {
            return _iRepository.Delete(id);

        }
        public AvrechEntity GetByName(string firstName)
        {
            return _iRepository.GetByName(firstName);

        }
        
    }
}
