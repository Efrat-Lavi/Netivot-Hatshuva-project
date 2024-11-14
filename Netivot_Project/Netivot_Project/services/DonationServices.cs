using Netivot_Project.Enums;

namespace Netivot_Project.entities
{
    public class DonationServices
    {
        readonly IDataContextDonation _donationService;
        public DonationServices(IDataContextDonation customerService)
        {
            _donationService = customerService;
        }

        //********************************************************
        public List<DonationEntity> GetAllDonations()
        {
            var data = _donationService.LoadData();
            return data;
        }
        //public List<DonationEntity> GetAllDonations()
        //{
        //    return DataManager.dataContexts.donations;
        //}

        //********************************************************
        public DonationEntity GetDonationById(int id)
        {
           
            var data = _donationService.LoadData();
            return data.Find(d => d.Id == id);
        }
        //public DonationEntity GetDonationById(int id)
        //{
        //    return DataManager.dataContexts.donations.Find(d => d.Id == id);
        //}

        //********************************************************
        public bool AddDonation(DonationEntity donation)
        {
            var data = _donationService.LoadData();
            if (data == null)
                return false;
            if (donation == null || data.Exists(d => d.Id == donation.Id))
                return false;
            data.Add(donation);
            return _donationService.SaveData(data);
        }
        //public bool AddDonation(DonationEntity donation)
        //{
        //    if (DataManager.dataContexts.donations == null)
        //        DataManager.dataContexts.donations = new List<DonationEntity>();
        //    if (donation == null || DataManager.dataContexts.donations.Exists(d => d.Id == donation.Id))
        //        return false;
        //    DataManager.dataContexts.donations.Add(new DonationEntity(donation));
        //    return true;
        //}

        //********************************************************
        public bool UpdateDonation(int id, DonationEntity donation)
        {
            var data = _donationService.LoadData();
            if (data == null)
                return false;
            int i = data.FindIndex(c => c.Id == id);
            if (i == -1)
                return false;
            data[i].IdDonor = donation.IdDonor;
            data[i].Date = donation.Date;
            data[i].Sum = donation.Sum;
            data[i].DonationStatus = donation.DonationStatus;
            return _donationService.SaveData(data);
        }
        //public bool UpdateDonation(int id, DonationEntity donation)
        //{
        //    if (DataManager.dataContexts.donations == null || donation == null)
        //        return false;
        //    int i = DataManager.dataContexts.donations.FindIndex(d => d.Id == id);
        //    DataManager.dataContexts.donations[i].IdDonor = donation.IdDonor;
        //    DataManager.dataContexts.donations[i].Date = donation.Date;
        //    DataManager.dataContexts.donations[i].Sum = donation.Sum;
        //    DataManager.dataContexts.donations[i].DonationStatus = donation.DonationStatus;
        //    return true;
        //}

        //********************************************************
        public bool DeleteDonation(int id)
        {
            var data = _donationService.LoadData();
            if (data == null || !data.Exists(d => d.Id == id))
                return false;
            data.Remove(GetDonationById(id));
            return _donationService.SaveData(data);
        }
        //public bool DeleteDonation(int id)
        //{
        //    if (DataManager.dataContexts.donations == null || !DataManager.dataContexts.donations.Exists(d => d.Id == id))
        //        return false;
        //    DataManager.dataContexts.donations.Remove(GetDonationById(id));
        //    return true;
        //}

        public DonationEntity GetDonationByDate(DateOnly date)
        {
            if (DataManager.dataContexts.donations == null)
                return null;
            return DataManager.dataContexts.donations.Find(d => d.Date.CompareTo( date)==0);
        }

    }
}
