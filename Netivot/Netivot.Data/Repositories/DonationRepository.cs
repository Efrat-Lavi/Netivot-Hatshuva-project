using Netivot.Core.Entities;
using Netivot.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Data.Repositories
{
    public class DonationRepository:IRepository<DonationEntity>
    {
        private readonly DataContext _dataContext;
        public DonationRepository(DataContext context)
        {
            _dataContext = context;
        }
        public List<DonationEntity> GetAll()
        {
            return _dataContext.donations;
        }
        public DonationEntity GetById(int id)
        {
            return _dataContext.donations.Find(d => d.Id == id);
        }
        public bool Add(DonationEntity donation)
        {
            if (_dataContext.donations == null)
                _dataContext.donations = new List<DonationEntity>();
            if (donation == null || _dataContext.donations.Exists(d => d.Id == donation.Id))
                return false;
            _dataContext.donations.Add(new DonationEntity(donation));
            return _dataContext.Save<DonationEntity>(_dataContext.donations, "Donations.csv"); ;
        }
        public bool Update(int id, DonationEntity donation)
        {
            if (_dataContext.donations == null || donation == null)
                return false;
            int i = _dataContext.donations.FindIndex(d => d.Id == id);
            if (i == -1)
                return false;
            _dataContext.donations[i].IdDonor = donation.IdDonor;
            _dataContext.donations[i].Date = donation.Date;
            _dataContext.donations[i].Sum = donation.Sum;
            _dataContext.donations[i].DonationStatus = donation.DonationStatus;
            return _dataContext.Save<DonationEntity>(_dataContext.donations, "Donations.csv"); ;

        }
        public bool Delete(int id)
        {
            if (_dataContext.donations == null || !_dataContext.donations.Exists(d => d.Id == id))
                return false;
            _dataContext.donations.Remove(GetById(id));
            return _dataContext.Save<DonationEntity>(_dataContext.donations, "Donations.csv"); ;
        }

        public DonationEntity GetByName(string name)
        {
            if (_dataContext.donations == null)
                return null;
            DateTime date = System.DateTime.ParseExact(name, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
            return _dataContext.donations.Find(d => d.Date.CompareTo(date) == 0);
        }
    }
}
