using Netivot_Project.entities;
using Netivot_Project.Enums;

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
            donations.Add(new DonationEntity(3, 3, new DateTime(), 10, ActiveStatusEnum.Active));

        }
    }
}
