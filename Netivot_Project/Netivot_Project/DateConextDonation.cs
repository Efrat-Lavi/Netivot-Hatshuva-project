using CsvHelper.Configuration;
using CsvHelper;
using Netivot_Project.entities;
using System.Globalization;

namespace Netivot_Project
{
    public class DateConextDonation:IDataContextDonation
    {
        public List<DonationEntity> LoadData()
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "data.csv");
                using (var reader = new StreamReader(path))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<DonationEntity>();
                    return new List<DonationEntity>(records);
                }
            }
            catch
            {
                return null;
            }
        }
        public bool SaveData(List<DonationEntity> data)
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "data.csv");
                using var writer = new StreamWriter(path);
                using var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = true
                });
                csv.WriteRecords(data);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
