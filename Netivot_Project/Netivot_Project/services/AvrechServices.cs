using System;

namespace Netivot_Project.entities
{
    public class AvrechServices
    {
        static List<AvrechEntity> avrechim;
        public List<AvrechEntity> GetAllAvrechim()
        {
            return avrechim;
        }
        public AvrechEntity GetAvrechById(int id)
        {
            if (avrechim == null)
                return null;
            return avrechim.Find(a=>a.Id == id);
        }
        public bool PostAvrech(AvrechEntity avrech)
        {
            if (avrechim == null)
                avrechim = new List<AvrechEntity>();
            if (avrech == null || avrechim.Exists(a => a.Id == avrech.Id))
                return false;
            avrechim.Add(new AvrechEntity (avrech));
            return true;
        }
        public bool PutAvrech(int id, AvrechEntity avrech)
        {
            if (avrechim == null || avrech == null)
                return false;
            int i = avrechim.FindIndex(a => a.Id == id);
            avrechim[i] = new AvrechEntity(avrech);
            return true;
        }
        public bool DeleteAvrech(int id)
        {
            if (avrechim == null || !avrechim.Exists(a => a.Id == id))
                return false;
            avrechim.Remove(GetAvrechById(id));
            return true;
        }
        public AvrechEntity GetAvrechByName(string firstName)
        {
            if (avrechim == null)
                return null;
            return avrechim.Find(a => a.FirstName == firstName);
        }
    }
}
