using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Reflection;

namespace Netivot_Project.entities
{
    public class AvrechServices
    {
        public List<AvrechEntity> GetAllAvrechim()
        {
            return DataManager.dataContexts.avrechim;
        }
        public AvrechEntity GetAvrechById(int id)
        {
            if (DataManager.dataContexts.avrechim == null)
                return null;
            return DataManager.dataContexts.avrechim.Find(a=>a.Id == id);
        }
        public bool AddAvrech(AvrechEntity avrech)
        {
            if (DataManager.dataContexts.avrechim == null)
                DataManager.dataContexts.avrechim = new List<AvrechEntity>();
            if (avrech == null || DataManager.dataContexts.avrechim.Exists(a => a.Id == avrech.Id))
                return false;
            DataManager.dataContexts.avrechim.Add(new AvrechEntity (avrech));
            return true;
        }
        public bool UpdateAvrech(int id, AvrechEntity avrech)
        {
            if (DataManager.dataContexts.avrechim == null || avrech == null)
                return false;
            int i = DataManager.dataContexts.avrechim.FindIndex(a => a.Id == id);
            DataManager.dataContexts.avrechim[i].FirstName = avrech.FirstName;
            DataManager.dataContexts.avrechim[i].LastName = avrech.LastName;
            DataManager.dataContexts.avrechim[i].Gender = avrech.Gender;
            DataManager.dataContexts.avrechim[i].Age = avrech.Age;
            DataManager.dataContexts.avrechim[i].Email = avrech.Email;
            DataManager.dataContexts.avrechim[i].PhoneNumber = avrech.PhoneNumber;
            DataManager.dataContexts.avrechim[i].WorkStatus = avrech.WorkStatus;
            DataManager.dataContexts.avrechim[i].JobDay = avrech.JobDay;
            return true;
        }
        public bool DeleteAvrech(int id)
        {
            if (DataManager.dataContexts.avrechim == null || !DataManager.dataContexts.avrechim.Exists(a => a.Id == id))
                return false;
            DataManager.dataContexts.avrechim.Remove(GetAvrechById(id));
            return true;
        }
        public AvrechEntity GetAvrechByName(string firstName)
        {
            if (DataManager.dataContexts.avrechim == null)
                return null;
            return DataManager.dataContexts.avrechim.Find(a => a.FirstName == firstName);
        }
    }
}
