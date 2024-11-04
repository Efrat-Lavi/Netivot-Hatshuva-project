namespace Netivot_Project.entities
{
    public class MitchazekServices
    {
        static List<MitchazekEntity> mitchazkim;
        public List<MitchazekEntity> GetAllMitchazkim()
        {
            return mitchazkim;
        }
        public MitchazekEntity GetMitchazekById(int id)
        {
            if (mitchazkim == null)
                return null;
            return mitchazkim.Find(m => m.Id == id);
        }
        public bool PostMitchazek(MitchazekEntity mitchazek)
        {
            if (mitchazkim == null)
                mitchazkim = new List<MitchazekEntity>();
            if (mitchazek == null || mitchazkim.Exists(m => m.Id == mitchazek.Id))
                return false;
            mitchazkim.Add(new MitchazekEntity(mitchazek));
            return true;
        }
        public bool PutMitchazek(int id, MitchazekEntity mitchazek)
        {
            if (mitchazkim == null || mitchazek == null)
                return false;
            int i = mitchazkim.FindIndex(m => m.Id == id);
            mitchazkim[i] = new MitchazekEntity(mitchazek);
            return true;
        }
        public bool DeleteMitchazek(int id)
        {
            if (mitchazkim == null || !mitchazkim.Exists(m => m.Id == id))
                return false;
            mitchazkim.Remove(GetMitchazekById(id));
            return true;
        }
        public MitchazekEntity GetMitchazekByName(string firstName)
        {
            if (mitchazkim == null)
                return null;
            return mitchazkim.Find(m => m.FirstName == firstName);
        }

    }
}
