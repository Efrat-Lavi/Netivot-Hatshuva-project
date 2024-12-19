using Netivot.Core.Entities;
using Netivot.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Service
{
    public class MitchazekServices:IMitchazekService
    {
        readonly IRepository<MitchazekEntity> _iRepository;
        public MitchazekServices(IRepository<MitchazekEntity> iRepository)
        {
            _iRepository = iRepository;
        }
        public List<MitchazekEntity> GetAllMitchazkim()
        {
            return _iRepository.GetAll();
        }
        public MitchazekEntity GetMitchazekById(int id)
        {
            return _iRepository.GetById(id);

        }
        public bool AddMitchazek(MitchazekEntity mitchazek)
        {
            return _iRepository.Add(mitchazek);

        }
        public bool UpdateMitchazek(int id, MitchazekEntity mitchazek)
        {
            return _iRepository.Update(id, mitchazek);

        }
        public bool DeleteMitchazek(int id)
        {
            return _iRepository.Delete(id);

        }
        public MitchazekEntity GetMitchazekByName(string firstName)
        {
            return _iRepository.GetByName(firstName);

        }
    }
}
