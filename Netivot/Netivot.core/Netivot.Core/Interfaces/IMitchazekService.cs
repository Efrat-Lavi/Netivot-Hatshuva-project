using Netivot.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Core.Interfaces
{
    public interface IMitchazekService
    {
        List<MitchazekEntity> GetAllMitchazkim();
        MitchazekEntity GetMitchazekById(int id);
        bool AddMitchazek(MitchazekEntity t);
        bool UpdateMitchazek(int id, MitchazekEntity t);
        bool DeleteMitchazek(int id);
        MitchazekEntity GetMitchazekByName(string firstName);
        
    }
}
