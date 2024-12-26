using Netivot.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Core.Interfaces.IRepositories
{
    public interface IMitchazekRepoisitory:IRepository<MitchazekEntity>
    {
        List<MitchazekEntity> GetFull();
    }
}
