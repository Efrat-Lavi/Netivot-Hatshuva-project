using Netivot.Core.Entities;
using Netivot.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Service
{
    public class MeetingServices:IService<MeetingEntity>
    {
        readonly IRepository<MeetingEntity> _iRepository;
        public MeetingServices(IRepository<MeetingEntity> iRepository)
        {
            _iRepository = iRepository;
        }
        public List<MeetingEntity> GetAll()
        {
            return _iRepository.GetAll();
        }
        public MeetingEntity GetById(int id)
        {
            return _iRepository.GetById(id);

        }
        public bool Add(MeetingEntity meeting)
        {
            return _iRepository.Add(meeting);

        }
        public bool Update(int id, MeetingEntity meeting)
        {
            return _iRepository.Update(id, meeting);

        }
        public bool Delete(int id)
        {
            return _iRepository.Delete(id);

        }
        public MeetingEntity GetByName(string firstName)
        {
            return _iRepository.GetByName(firstName);

        }
    }
}
