using Netivot_Project.Enums;

namespace Netivot_Project.entities
{
    public class DonationServices
    {
        public List<DonationEntity> GetAllDonations()
        {
            return DataManager.dataContexts.donations;
        }
        public DonationEntity GetDonationById(int id)
        {
            return DataManager.dataContexts.donations.Find(d => d.Id == id);
        }
        public bool AddDonation(DonationEntity donation)
        {
            if (DataManager.dataContexts.donations == null)
                DataManager.dataContexts.donations = new List<DonationEntity>();
            if (donation == null || DataManager.dataContexts.donations.Exists(d => d.Id == donation.Id))
                return false;
            DataManager.dataContexts.donations.Add(new DonationEntity(donation));
            return true;
        }
        public bool UpdateDonation(int id, DonationEntity donation)
        {
            if (DataManager.dataContexts.donations == null || donation == null)
                return false;
            int i = DataManager.dataContexts.donations.FindIndex(d => d.Id == id);
            DataManager.dataContexts.donations[i].IdDonor = donation.IdDonor;
            DataManager.dataContexts.donations[i].Date = donation.Date;
            DataManager.dataContexts.donations[i].Sum = donation.Sum;
            DataManager.dataContexts.donations[i].DonationStatus = donation.DonationStatus;
            return true;
        }
        public bool DeleteDonation(int id)
        {
            if (DataManager.dataContexts.donations == null || !DataManager.dataContexts.donations.Exists(d => d.Id == id))
                return false;
            DataManager.dataContexts.donations.Remove(GetDonationById(id));
            return true;
        }
        public DonationEntity GetDonationByDate(DateOnly date)
        {
            if (DataManager.dataContexts.donations == null)
                return null;
            return DataManager.dataContexts.donations.Find(d => d.Date.CompareTo( date)==0);
        }

    }
}
