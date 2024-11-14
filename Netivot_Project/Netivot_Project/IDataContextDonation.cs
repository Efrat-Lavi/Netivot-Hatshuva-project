using Netivot_Project.entities;

namespace Netivot_Project
{
    public interface IDataContextDonation
    {
        public List<DonationEntity> LoadData();
        public bool SaveData(List<DonationEntity> path);
    }
}
