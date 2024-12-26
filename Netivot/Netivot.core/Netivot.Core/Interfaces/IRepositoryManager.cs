using Netivot.Core.Entities;
using Netivot.Core.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Core.Interfaces
{
    public interface IRepositoryManager
    {
        IAvrechRepository _avrechRepository { get; }
        IDonorRepository _donorRepository { get; }
       IDonationRepository _donationRepository { get; }
        IMeetingRepository _meetingRepository { get; }
        IMitchazekRepoisitory _mitchazekRepository { get; }
        void save();
    }
}
