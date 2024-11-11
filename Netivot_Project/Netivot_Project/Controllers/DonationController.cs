using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Netivot_Project.entities;

namespace Netivot_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationController : Controller
    {
        // GET: DonationController
        DonationServices donationServices = new DonationServices();
        // GET: api/<DonationController>
        [HttpGet]
        public ActionResult<List<DonationEntity>> Get()
        {
            List<DonationEntity> donations = donationServices.GetAllDonations();
            //if (donations == null)
            //    return NotFound();
            return donations;
        }
    


        // GET api/<DonationController>/5
        [HttpGet("{id}")]
        public ActionResult<DonationEntity> Get(int id)
        {
            DonationEntity donation = donationServices.GetDonationById(id);
            if (donation == null)
                return NotFound();
            return donation;
        }

        // POST api/<DonationController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] DonationEntity value)
        {
            bool isSuccess = donationServices.AddDonation(value);
            return isSuccess ? true : false;
        }

        // PUT api/<DonationController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] DonationEntity value)
        {
            bool isSuccess = donationServices.UpdateDonation(id, value);
            return isSuccess ? true : false;
        }

        // DELETE api/<DonationController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool isSuccess = donationServices.DeleteDonation(id);
            return isSuccess ? true : false;
        }
    }
}
