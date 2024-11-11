namespace Netivot_Project.entities
{
    public class DonorServices
    {
        public List<DonorEntity> GetAllDonors()
        {
            return DataManager.dataContexts.donors;
        }
        public DonorEntity GetDonorById(int id)
        {
            if (DataManager.dataContexts.donors == null)
                return null;
            return DataManager.dataContexts.donors.Find(d => d.Id == id);
        }
        public bool AddDonor(DonorEntity donor)
        {
            if (DataManager.dataContexts.donors == null)
                DataManager.dataContexts.donors = new List<DonorEntity>();
            if (donor == null || DataManager.dataContexts.donors.Exists(d => d.Id == donor.Id))
                return false;
            DataManager.dataContexts.donors.Add(new DonorEntity(donor));
            return true;
        }
        public bool UpdateDonor(int id, DonorEntity donor)
        {
            if (DataManager.dataContexts.donors == null || donor == null)
                return false;
            int i = DataManager.dataContexts.donors.FindIndex(d => d.Id == id);
            DataManager.dataContexts.donors[i].FirstName = donor.FirstName;
            DataManager.dataContexts.donors[i].LastName = donor.LastName;
            DataManager.dataContexts.donors[i].Email = donor.Email;
            DataManager.dataContexts.donors[i].PhoneNumber = donor.PhoneNumber;
            DataManager.dataContexts.donors[i].DonorStatus = donor.DonorStatus;
            DataManager.dataContexts.donors[i].LastDonation = donor.LastDonation;
            return true;
        }
        public bool DeleteDonor(int id)
        {
            if (DataManager.dataContexts.donors == null || !DataManager.dataContexts.donors.Exists(d => d.Id == id))
                return false;
            DataManager.dataContexts.donors.Remove(GetDonorById(id));
            return true;
        }
        public DonorEntity GetDonorByName(string firstName)
        {
            if (DataManager.dataContexts.donors == null)
                return null;
            return DataManager.dataContexts.donors.Find(d => d.FirstName == firstName);
        }
    }
}
