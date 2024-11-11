using Microsoft.AspNetCore.Mvc;
using Netivot_Project.Controllers;
using Netivot_Project.entities;
using Netivot_Project.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class DonationControllerTest
    {
        [Fact]
        public void GetAll_ReturnListOfDonatins()
        {
            var controller = new DonationController();
            var result = controller.Get();
            Assert.IsType<ActionResult<List<DonationEntity>>>(result);

        }
        [Fact]
        public void Post_ReturnTrue()
        {

            DonationEntity obj = new DonationEntity(1, 1, new DateTime(), 100, ActiveStatusEnum.Active);
            var controller = new DonationController();
            bool result = controller.Post(obj).Value;
            Assert.True(result);
        }

        [Fact]
        public void Put_ReturnFalse()
        {
            var id = 5;
            DonationEntity obj = new DonationEntity(1, 1, new DateTime(), 100, ActiveStatusEnum.Active);
            var controller = new DonationController();
            bool result = controller.Put(id, obj).Value;
            Assert.False(result);
        }
        [Fact]
        public void Get_ReturnUsers()
        {
            var id = 3;
            var controller = new DonationController();
            var result = controller.Get(id);
            Assert.IsType<ActionResult<DonationEntity>>(result);
        }



    }
}
