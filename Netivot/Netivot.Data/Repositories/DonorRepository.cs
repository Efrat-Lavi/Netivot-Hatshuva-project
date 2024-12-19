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
            return _dataContext.donors.ToList();
        }
        public DonorEntity GetById(int id)
        {
            if (_dataContext.donors == null)
                return null;
            return _dataContext.donors.Find(id);
        }
        public bool Add(DonorEntity donor)
        {
            if (donor == null || _dataContext.donors.Find(donor.Id) != null)
                return false;
            _dataContext.donors.Add(new DonorEntity(donor));
            try
            {
                _dataContext.SaveChanges();
                return true;
            }
            catch { return false; }
        }
        public bool Update(int id, DonorEntity donor)
        {
            if (_dataContext.donors == null || donor == null)
                return false;
            DonorEntity d = _dataContext.donors.Find(id);
            if (d == null)
                return false;
            d.FirstName = donor.FirstName;
            d.LastName = donor.LastName;
            d.Email = donor.Email;
            d.PhoneNumber = donor.PhoneNumber;
            d.DonorStatus = donor.DonorStatus;
            d.LastDonation = donor.LastDonation;
            try
            {
                _dataContext.SaveChanges();
                return true;
            }
            catch { return false; }
        }
        public bool Delete(int id)
        {
            if (_dataContext.donors == null || _dataContext.donors.Find(id) != null)
                return false;
            _dataContext.donors.Remove(GetById(id));
            try
            {
                _dataContext.SaveChanges();
                return true;
            }
            catch { return false; }
        }
        public DonorEntity GetByName(string firstName)
        {
            if (_dataContext.donors == null)
                return null;
            return _dataContext.donors.Find(firstName);
        }
    }
}
