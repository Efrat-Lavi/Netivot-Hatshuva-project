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
        public MitchazekServices(IRepositoryManager repository)
        {
            _iRepository = repository;
        }
        public List<MitchazekEntity> GetAllMitchazkim()
        {
            return _iRepository._mitchazekRepository.GetFull();
        }
        public MitchazekEntity GetMitchazekById(int id)
        {
            return _iRepository._mitchazekRepository.GetById(id);

        }
        public bool AddMitchazek(MitchazekEntity mitchazek)
        {
            bool succeed = _iRepository._mitchazekRepository.Add(mitchazek);
            if (succeed)
                _iRepository.save();
            return succeed;
        }
        public bool UpdateMitchazek(int id, MitchazekEntity mitchazek)
        {
            bool succeed = _iRepository._mitchazekRepository.Update(id,mitchazek);
            if (succeed)
                _iRepository.save();
            return succeed;

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
