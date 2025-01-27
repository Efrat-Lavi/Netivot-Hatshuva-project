using Netivot.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Core.Interfaces.IServices
{
    public interface IMitchazekService
    {
        IEnumerable<MitchazekDto> GetAllMitchazkim();
        MitchazekDto GetMitchazekById(int id);
        MitchazekDto AddMitchazek(MitchazekDto t);
        MitchazekDto UpdateMitchazek(int id, MitchazekDto t);
        bool DeleteMitchazek(int id);
        //MitchazekEntity GetMitchazekByName(string firstName);

    }
}
