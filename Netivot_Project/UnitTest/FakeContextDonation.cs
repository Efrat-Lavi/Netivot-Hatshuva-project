using Netivot_Project.entities;
using Netivot_Project.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class FakeContext
    {
        public List<DonationEntity> LoadData()
        {
            List<DonationEntity> list = new List<DonationEntity>();
            list.Add(new DonationEntity(3, 3, new DateTime(), 10, ActiveStatusEnum.Active));
            return list;
        }

        public bool SaveData(List<DonationEntity> list)
        {
            return true;
        }
       
    }
}
