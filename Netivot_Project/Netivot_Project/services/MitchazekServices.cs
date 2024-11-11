using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

namespace Netivot_Project.entities
{
    public class MitchazekServices
    {
        public List<MitchazekEntity> GetAllMitchazkim()
        {
            return DataManager.dataContexts.mitchazkim;
        }
        public MitchazekEntity GetMitchazekById(int id)
        {
            if (DataManager.dataContexts.mitchazkim == null)
                return null;
            return DataManager.dataContexts.mitchazkim.Find(m => m.Id == id);
        }
        public bool AddMitchazek(MitchazekEntity mitchazek)
        {
            if (DataManager.dataContexts.mitchazkim == null)
                DataManager.dataContexts.mitchazkim = new List<MitchazekEntity>();
            if (mitchazek == null || DataManager.dataContexts.mitchazkim.Exists(m => m.Id == mitchazek.Id))
                return false;
            DataManager.dataContexts.mitchazkim.Add(new MitchazekEntity(mitchazek));
            return true;
        }
        public bool UpdateMitchazek(int id, MitchazekEntity mitchazek)
        {
            if (DataManager.dataContexts.mitchazkim == null || mitchazek == null)
                return false;
            int i = DataManager.dataContexts.mitchazkim.FindIndex(m => m.Id == id);
            DataManager.dataContexts.mitchazkim[i].FirstName = mitchazek.FirstName;
            DataManager.dataContexts.mitchazkim[i].LastName = mitchazek.LastName;
            DataManager.dataContexts.mitchazkim[i].Gender = mitchazek.Gender;
            DataManager.dataContexts.mitchazkim[i].Age = mitchazek.Age;
            DataManager.dataContexts.mitchazkim[i].Email = mitchazek.Email;
            DataManager.dataContexts.mitchazkim[i].PhoneNumber = mitchazek.PhoneNumber;
            DataManager.dataContexts.mitchazkim[i].SpiritualState = mitchazek.SpiritualState;
            DataManager.dataContexts.mitchazkim[i].MaritalStatus = mitchazek.MaritalStatus;
            DataManager.dataContexts.mitchazkim[i].PreferredDay = mitchazek.PreferredDay;
            return true;
        }
        public bool DeleteMitchazek(int id)
        {
            if (DataManager.dataContexts.mitchazkim == null || !DataManager.dataContexts.mitchazkim.Exists(m => m.Id == id))
                return false;
            DataManager.dataContexts.mitchazkim.Remove(GetMitchazekById(id));
            return true;
        }
        public MitchazekEntity GetMitchazekByName(string firstName)
        {
            if (DataManager.dataContexts.mitchazkim == null)
                return null;
            return DataManager.dataContexts.mitchazkim.Find(m => m.FirstName == firstName);
        }

    }
}
