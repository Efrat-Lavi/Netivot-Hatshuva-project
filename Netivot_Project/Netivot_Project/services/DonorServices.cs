namespace Netivot_Project.entities
{
    public class DonorServices
    {
        List<DonorEntity> donors;
        public List<DonorEntity> GetAllDonors()
        {
            return donors;
        }
        public DonorEntity GetDonorById(int id)
        {
            if (donors == null)
                return null;
            return donors.Find(d => d.Id == id);
        }
        public bool PostDonor(DonorEntity donor)
        {
            if (donors == null)
                donors = new List<DonorEntity>();
            if (donor == null || donors.Exists(d => d.Id == donor.Id))
                return false;
            donors.Add(new DonorEntity(donor));
            return true;
        }
        public bool PutDonor(int id, DonorEntity donor)
        {
            if (donors == null || donor == null)
                return false;
            int i = donors.FindIndex(d => d.Id == id);
            donors[i] = new DonorEntity(donor);
            return true;
        }
        public bool DeleteDonor(int id)
        {
            if (donors == null || !donors.Exists(d => d.Id == id))
                return false;
            donors.Remove(GetDonorById(id));
            return true;
        }
        public DonorEntity GetDonorByName(string firstName)
        {
            if (donors == null)
                return null;
            return donors.Find(d => d.FirstName == firstName);
        }
    }
}
