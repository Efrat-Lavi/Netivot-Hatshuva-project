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
    public class RepositoryManager : IRepositoryManager
    {
        DataContext _dataContext;
        public IAvrechRepository _avrechRepository { get; }
        public IDonorRepository _donorRepository { get; }
        public IDonationRepository _donationRepository { get; }
        public IMeetingRepository _meetingRepository { get; }
        public IMitchazekRepoisitory _mitchazekRepository { get; }
        public RepositoryManager(DataContext dataContext, IAvrechRepository avrech, IDonorRepository donor, IDonationRepository donation, IMeetingRepository meeting,IMitchazekRepoisitory mitchazek)
        {
            _avrechRepository = avrech;
            _donorRepository = donor;
            _donationRepository = donation;
            _meetingRepository = meeting;
            _mitchazekRepository = mitchazek;
            _dataContext = dataContext;
        }

        public void save()
        {
            _dataContext.SaveChanges();
        }
    }
}
