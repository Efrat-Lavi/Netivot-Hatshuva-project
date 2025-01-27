using AutoMapper;
using Netivot.Core;
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
        private readonly IRepositoryManager _iRepository;
        private readonly IMapper _mapper;
        public AvrechServices(IRepositoryManager iRepository,IMapper mapper)
        {
            _iRepository = iRepository;
            _mapper  = mapper;
        }
        public IEnumerable<AvrechDto> GetAllAvrechim()
        {
            var avrechim = _iRepository._avrechRepository.GetFull();
            var avrechimDto = _mapper.Map<IEnumerable<AvrechDto>>(avrechim);
            return avrechimDto;
        }
        public AvrechDto GetAvrechById(int id)
        {
            var avrech = _iRepository._avrechRepository.GetById(id);
            var avrechimDto = _mapper.Map<AvrechDto>(avrech);
            return avrechimDto;
        }
        public AvrechDto AddAvrech(AvrechDto avrechDto)
        {
            var avrechEntity = _mapper.Map<AvrechEntity>(avrechDto);
            avrechEntity =  _iRepository._avrechRepository.Add(avrechEntity);
            if (avrechEntity != null)
            {
                _iRepository.save();
                return avrechDto;
            }
            return null;
        }
        public AvrechDto UpdateAvrech(int id, AvrechDto avrechDto)
        {
            var avrechEntity = _mapper.Map<AvrechEntity>(avrechDto);
            avrechEntity = _iRepository._avrechRepository.Update(id, avrechEntity);
            if (avrechEntity != null)
            {
                _iRepository.save();
                return avrechDto;
            }
            return null;
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
