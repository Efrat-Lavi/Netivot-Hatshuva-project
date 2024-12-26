using Netivot.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Core.Interfaces.IRepositories
{
    public interface IDonationRepository:IRepository<DonationEntity>
    {
        List<DonationEntity> GetFull();

    }
}
