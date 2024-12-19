using Netivot.Core.Entities;
using Netivot.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Service
{
    public class AvrechServices : IAvrechService
    {
        readonly IRepository<AvrechEntity> _iRepository;
        public AvrechServices(IRepository<AvrechEntity> iRepository)
        {
            _iRepository = iRepository;
        }
        public List<AvrechEntity> GetAllAvrechim()
        {
            return _iRepository.GetAll();
        }
        public AvrechEntity GetAvrechById(int id)
        {
            return _iRepository.GetById(id);

        }
        public bool AddAvrech(AvrechEntity avrech)
        {
            return _iRepository.Add(avrech);

        }
        public bool UpdateAvrech(int id, AvrechEntity avrech)
        {
            return _iRepository.Update(id, avrech);

        }
        public bool DeleteAvrech(int id)
        {
            return _iRepository.Delete(id);

        }
        public AvrechEntity GetAvrechByName(string firstName)
        {
            return _iRepository.GetByName(firstName);

        }
        
    }
}
