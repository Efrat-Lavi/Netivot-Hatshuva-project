using Microsoft.EntityFrameworkCore;
using Netivot.Core.Entities;
using Netivot.Core.Interfaces;
using Netivot.Core.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Data.Repositories
{
    public class DonationRepository:Repository<DonationEntity>,IDonationRepository
    {
       
        public DonationRepository(DataContext dataContext)
            : base(dataContext)
        {
           
        }
        public List<DonationEntity> GetFull()
        {
            return _dbSet.ToList();
        }
        //private readonly DataContext _dataContext;
        //public DonationRepository(DataContext context)
        //{
        //    _dataContext = context;
        //}
        //public List<DonationEntity> GetAll()
        //{
        //    return _dataContext.donations.ToList();
        //}
        //public DonationEntity GetById(int id)
        //{
        //    return _dataContext.donations.ToList().Find(d => d.Id == id);
        //}
        //public bool Add(DonationEntity donation)
        //{

        //    if (donation == null || _dataContext.donations.Find(donation.Id) != null)
        //        return false;
        //    _dataContext.donations.Add(new DonationEntity(donation));
        //    try
        //    {
        //        _dataContext.SaveChanges();
        //        return true;
        //    }
        //    catch { return false; }
        //}
        //public bool Update(int id, DonationEntity donation)
        //{
        //    if (_dataContext.donations == null || donation == null)
        //        return false;
        //    DonationEntity d = _dataContext.donations.Find(id);
        //    if (d == null)
        //        return false;
        //    d.IdDonor = donation.IdDonor;
        //    d.Date = donation.Date;
        //    d.Sum = donation.Sum;
        //    d.DonationStatus = donation.DonationStatus;
        //    try
        //    {
        //        _dataContext.SaveChanges();
        //        return true;
        //    }
        //    catch { return false; }
        //}
        //public bool Delete(int id)
        //{
        //    if (_dataContext.donations == null || _dataContext.donations.Find(id) == null)
        //        return false;
        //    _dataContext.donations.Remove(GetById(id));
        //try
        //    {
        //        _dataContext.SaveChanges();
        //        return true;
        //    }
        //    catch  { return false; }        }

        //public DonationEntity GetByName(string name)
        //{
        //    if (_dataContext.donations == null)
        //        return null;
        //    DateTime date = System.DateTime.ParseExact(name, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
        //    return _dataContext.donations.Find(date);
        //}
    }
}
