using Netivot.Core.Entities;
using Netivot.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Data.Repositories
{
    public class DonorRepository:IRepository<DonorEntity>
    {
        private readonly DataContext _dataContext;
        public DonorRepository(DataContext context)
        {
            _dataContext = context;
        }
        public List<DonorEntity> GetAll()
        {
            return _dataContext.donors;
        }
        public DonorEntity GetById(int id)
        {
            if (_dataContext.donors == null)
                return null;
            return _dataContext.donors.Find(d => d.Id == id);
        }
        public bool Add(DonorEntity donor)
        {
            if (_dataContext.donors == null)
                _dataContext.donors = new List<DonorEntity>();
            if (donor == null || _dataContext.donors.Exists(d => d.Id == donor.Id))
                return false;
            _dataContext.donors.Add(new DonorEntity(donor));
            return _dataContext.Save<DonorEntity>(_dataContext.donors, "Donors.csv"); ;
        }
        public bool Update(int id, DonorEntity donor)
        {
            if (_dataContext.donors == null || donor == null)
                return false;
            int i = _dataContext.donors.FindIndex(d => d.Id == id);
            if (i == -1)
                return false;
            _dataContext.donors[i].FirstName = donor.FirstName;
            _dataContext.donors[i].LastName = donor.LastName;
            _dataContext.donors[i].Email = donor.Email;
            _dataContext.donors[i].PhoneNumber = donor.PhoneNumber;
            _dataContext.donors[i].DonorStatus = donor.DonorStatus;
            _dataContext.donors[i].LastDonation = donor.LastDonation;
            return _dataContext.Save<DonorEntity>(_dataContext.donors, "Donors.csv"); ;
        }
        public bool Delete(int id)
        {
            if (_dataContext.donors == null || !_dataContext.donors.Exists(d => d.Id == id))
                return false;
            _dataContext.donors.Remove(GetById(id));
            return _dataContext.Save<DonorEntity>(_dataContext.donors, "Donors.csv"); ;
        }
        public DonorEntity GetByName(string firstName)
        {
            if (_dataContext.donors == null)
                return null;
            return _dataContext.donors.Find(d => d.FirstName == firstName);
        }
    }
}
