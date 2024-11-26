using CsvHelper;
using CsvHelper.Configuration;
using Netivot.Core.Entities;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Netivot.Data
{
    public class DataContext
    {
        public List<AvrechEntity> avrechim { get; set; }
        public List<DonationEntity> donations { get; set; }
        public List<DonorEntity> donors { get; set; }
        public List<MeetingEntity> meetings { get; set; }
        public List<MitchazekEntity> mitchazkim { get; set; }

        public DataContext()
        {
            avrechim = Load<AvrechEntity>("Avrechim.csv");
            donations = Load<DonationEntity>("Donations.csv");
            donors = Load<DonorEntity>("Donors.csv");
            meetings = Load<MeetingEntity>("Meetings.csv");
            mitchazkim = Load<MitchazekEntity>("Mitchazkim.csv");
        }

        private List<T> Load<T>(string pathCsv)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", pathCsv);
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture));
            return csv.GetRecords<T>().ToList();
        }

        public bool Save<T>(List<T> lst, string pathCsv)
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Data", pathCsv);
                using var writer = new StreamWriter(path);
                using var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture));
                csv.WriteRecords(lst);
                return true;
            }
            catch
            {
                return false;
            }
        }


        //public DataContext(DataPathes path)
        //{
        //    _path = path;
        //    if (!File.Exists(_path.AvrechimPath))
        //        File.Create(_path.AvrechimPath).Close();
        //    if (!File.Exists(_path.DonationsPath))
        //        File.Create(_path.DonationsPath).Close();
        //    if (!File.Exists(_path.DonorsPath))
        //        File.Create(_path.DonorsPath).Close();
        //    if (!File.Exists(_path.MeetingsPath))
        //        File.Create(_path.MeetingsPath).Close();
        //    if (!File.Exists(_path.MitchazkimPath))
        //        File.Create(_path.MitchazkimPath).Close();
        //    LoadAvrechimData();
        //    LoadDonationsData();
        //    LoadDonorsData();
        //    LoadMeetingsData();
        //    LoadMitchazkimData();
        //}

        //public bool LoadAvrechimData()
        //{
        //    try
        //    {
        //        if (new FileInfo(_path.AvrechimPath).Length > 0)
        //        {
        //            using (var reader = new StreamReader(_path.c))
        //            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        //            {
        //                avrechim = csv.GetRecords<AvrechEntity>().ToList();
        //            }
        //        }
        //        else
        //        {
        //            avrechim = new List<AvrechEntity>();
        //        }
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //public bool SaveAvrechimData()
        //{
        //    try
        //    {
        //        if (File.Exists(_path.AvrechimPath))
        //            File.Delete(_path.AvrechimPath);
        //        using (var writer = new StreamWriter(_path.AvrechimPath))
        //        using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
        //        {
        //            csv.WriteRecords(avrechim);
        //        }
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //public bool LoadDonationsData()
        //{
        //    try
        //    {
        //        if (new FileInfo(_path.DonationsPath).Length > 0)
        //        {
        //            using (var reader = new StreamReader(_path.DonationsPath))
        //            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        //            {
        //                donations = csv.GetRecords<DonationEntity>().ToList();
        //            }
        //        }
        //        else
        //        {
        //            donations = new List<DonationEntity>();
        //        }
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //public bool SaveDonationsData()
        //{
        //    try
        //    {
        //        if (File.Exists(_path.DonationsPath))
        //            File.Delete(_path.DonationsPath);
        //        using (var writer = new StreamWriter(_path.DonationsPath))
        //        using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
        //        {
        //            csv.WriteRecords(donations);
        //        }
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //public bool LoadDonorsData()
        //{
        //    try
        //    {
        //        if (new FileInfo(_path.DonorsPath).Length > 0)
        //        {

        //            using (var reader = new StreamReader(_path.DonorsPath))
        //            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        //            {
        //                donors = csv.GetRecords<DonorEntity>().ToList();
        //            }
        //        }
        //        else
        //        {
        //            donors = new List<DonorEntity>();
        //        }
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //public bool SaveDonorsData()
        //{
        //    try
        //    {
        //        if (File.Exists(_path.DonorsPath))
        //            File.Delete(_path.DonorsPath);
        //        using (var writer = new StreamWriter(_path.DonorsPath))
        //        using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
        //        {
        //            csv.WriteRecords(donors);
        //        }
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //public bool LoadMeetingsData()
        //{
        //    try
        //    {
        //        if (new FileInfo(_path.MeetingsPath).Length > 0)
        //        {

        //            using (var reader = new StreamReader(_path.MeetingsPath))
        //            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        //            {
        //                meetings = csv.GetRecords<MeetingEntity>().ToList();
        //            }
        //        }
        //        else
        //        {
        //            meetings = new List<MeetingEntity>();
        //        }
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }

        //}

        //public bool SaveMeetingsData()
        //{
        //    try
        //    {
        //        if (File.Exists(_path.MeetingsPath))
        //            File.Delete(_path.MeetingsPath);
        //        using (var writer = new StreamWriter(_path.MeetingsPath))
        //        using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
        //        {
        //            csv.WriteRecords(meetings);
        //        }
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //public bool LoadMitchazkimData()
        //{
        //    try
        //    {
        //        if (new FileInfo(_path.MitchazkimPath).Length > 0)
        //        {

        //            using (var reader = new StreamReader(_path.MitchazkimPath))
        //            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        //            {
        //                mitchazkim = csv.GetRecords<MitchazekEntity>().ToList();
        //            }
        //        }
        //        else
        //        {
        //            mitchazkim = new List<MitchazekEntity>();
        //        }
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //public bool SaveMitchazkimData()
        //{
        //    try
        //    {
        //        if (File.Exists(_path.MitchazkimPath))
        //            File.Delete(_path.MitchazkimPath);
        //        using (var writer = new StreamWriter(_path.MitchazkimPath))
        //        using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
        //        {
        //            csv.WriteRecords(mitchazkim);
        //        }
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //public class DataPathes
        //{
        //    private readonly string _basePath = Path.Combine(Directory.GetCurrentDirectory(), "..", "Netivot.Data", "Data");
        //    public string AvrechimPath { get; set; }
        //    public string DonationsPath { get; set; }
        //    public string DonorsPath { get; set; }
        //    public string MeetingsPath { get; set; }
        //    public string MitchazkimPath { get; set; }
        //    public DataPathes()
        //    {
        //        AvrechimPath = Path.Combine(_basePath, "avrechim_data.csv");
        //        DonationsPath = Path.Combine(_basePath, "donations_data.csv");
        //        DonorsPath = Path.Combine(_basePath, "donors_data.csv");
        //        MeetingsPath = Path.Combine(_basePath, "meetings_data.csv");
        //        MitchazkimPath = Path.Combine(_basePath, "mitchazkim_data.csv");
        //    }
        //}
    }
   
    
}
