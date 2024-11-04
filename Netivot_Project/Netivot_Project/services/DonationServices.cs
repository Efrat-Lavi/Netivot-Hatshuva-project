using Netivot_Project.Enums;

namespace Netivot_Project.entities
{
    public class DonationServices
    {
        List<DonationEntity> Donations;
        public List<DonationEntity> GetAllDonations()
        {
            return Donations;
        }
        public DonationEntity GetDonationById(int id)
        {
            if (Donations == null)
                return null;
            return Donations.Find(d => d.Id == id);
        }
        public bool PostDonation(DonationEntity donation)
        {
            if (Donations == null)
                Donations = new List<DonationEntity>();
            if (donation == null || Donations.Exists(d => d.Id == donation.Id))
                return false;
            Donations.Add(new DonationEntity(donation));
            return true;
        }
        public bool PutDonation(int id, DonationEntity donation)
        {
            if (Donations == null || donation == null)
                return false;
            int i = Donations.FindIndex(d => d.Id == id);
            Donations[i] = new DonationEntity(donation);
            return true;
        }
        public bool DeleteDonation(int id)
        {
            if (Donations == null || !Donations.Exists(d => d.Id == id))
                return false;
            Donations.Remove(GetDonationById(id));
            return true;
        }
        public DonationEntity GetDonationByDate(DateOnly date)
        {
            if (Donations == null)
                return null;
            return Donations.Find(d => d.Date.CompareTo( date)==0);
        }

    }
}
