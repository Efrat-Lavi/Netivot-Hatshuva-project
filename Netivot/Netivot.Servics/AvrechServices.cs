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
    public class AvrechServices : IAvrechService
    {
        readonly IRepositoryManager _iRepository;
        public AvrechServices(IRepositoryManager iRepository)
        {
            _iRepository = iRepository;
        }
        public List<AvrechEntity> GetAllAvrechim()
        {
            //return _iRepository._avrechRepository.GetAll();
            return _iRepository._avrechRepository.GetFull();
        }
        public AvrechEntity GetAvrechById(int id)
        {
            return _iRepository._avrechRepository.GetById(id);
        }
        public bool AddAvrech(AvrechEntity avrech)
        {
            bool succeed= _iRepository._avrechRepository.Add(avrech);
            if (succeed)
                _iRepository.save();
            return succeed;

        }
        public bool UpdateAvrech(int id, AvrechEntity avrech)
        {
            bool succeed = _iRepository._avrechRepository.Update(id, avrech);
            if (succeed)
                _iRepository.save();
            return succeed;
        }
        public bool DeleteAvrech(int id)
        {
            bool succeed = _iRepository._avrechRepository.Delete(id);
            if (succeed)
                _iRepository.save();
            return succeed;
        }
        //public AvrechEntity GetAvrechByName(string firstName)
        //{
        //    return _iRepository.GetByName(firstName);

        //}
        
    }
}
