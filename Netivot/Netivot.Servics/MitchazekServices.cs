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
    public class MitchazekServices:IMitchazekService
    {
        readonly IRepositoryManager _iRepository;
        private readonly IMapper _mapper;

        public MitchazekServices(IRepositoryManager iRepository, IMapper mapper)
        {
            _iRepository = iRepository;
            _mapper = mapper;
        }
        public IEnumerable<MitchazekDto> GetAllMitchazkim()
        {
            var mitchazkim = _iRepository._mitchazekRepository.GetFull();
            var mitchazkimDto = _mapper.Map<IEnumerable<MitchazekDto>>(mitchazkim);
            return mitchazkimDto;
        }
        public MitchazekDto GetMitchazekById(int id)
        {
            var mitchazek = _iRepository._mitchazekRepository.GetById(id);
            var mitchazekDto = _mapper.Map<MitchazekDto>(mitchazek);
            return mitchazekDto;

        }
        public MitchazekDto AddMitchazek(MitchazekDto mitchazekDto)
        {
            var mitchazek = _mapper.Map<MitchazekEntity>(mitchazekDto);
            mitchazek = _iRepository._mitchazekRepository.Add(mitchazek);
            if (mitchazek != null)
            {
                _iRepository.save();
                return mitchazekDto;
            }
            return null;
        }
        public MitchazekDto UpdateMitchazek(int id, MitchazekDto mitchazekDto)
        {
            var mitchazek = _mapper.Map<MitchazekEntity>(mitchazekDto);
            mitchazek = _iRepository._mitchazekRepository.Update(id,mitchazek);
            if (mitchazek != null)
            {
                _iRepository.save();
                return mitchazekDto;
            }
            return null;

        }
        public bool DeleteMitchazek(int id)
        {
            bool succeed = _iRepository._mitchazekRepository.Delete(id);
            if (succeed)
                _iRepository.save();
            return succeed;
        }
        //public MitchazekEntity GetMitchazekByName(string firstName)
        //{
        //    return _iRepository.GetByName(firstName);

        //}
    }
}
