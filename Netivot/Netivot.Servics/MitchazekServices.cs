using Netivot.Core.Entities;
using Netivot.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Service
{
    public class MitchazekServices:IService<MitchazekEntity>
    {
        readonly IRepository<MitchazekEntity> _iRepository;
        public MitchazekServices(IRepository<MitchazekEntity> iRepository)
        {
            _iRepository = iRepository;
        }
        public List<MitchazekEntity> GetAll()
        {
            return _iRepository.GetAll();
        }
        public MitchazekEntity GetById(int id)
        {
            return _iRepository.GetById(id);

        }
        public bool Add(MitchazekEntity mitchazek)
        {
            return _iRepository.Add(mitchazek);

        }
        public bool Update(int id, MitchazekEntity mitchazek)
        {
            return _iRepository.Update(id, mitchazek);

        }
        public bool Delete(int id)
        {
            return _iRepository.Delete(id);

        }
        public MitchazekEntity GetByName(string firstName)
        {
            return _iRepository.GetByName(firstName);

        }
    }
}
