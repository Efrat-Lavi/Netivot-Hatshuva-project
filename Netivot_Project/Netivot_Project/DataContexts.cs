using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.Extensions.Logging;
using Netivot_Project.entities;
using Netivot_Project.Enums;
using System.Formats.Asn1;
using System.Globalization;
using System.Text.Json;

namespace Netivot_Project
{
    public class DataContexts
    {
       public List<AvrechEntity> avrechim;
       public List<DonationEntity> donations;
       public List<DonorEntity> donors;
       public List<MeetingEntity> meetings;
       public List<MitchazekEntity> mitchazkim;

        public DataContexts()
        {
            donations = new List<DonationEntity>();


        }


    }
}
