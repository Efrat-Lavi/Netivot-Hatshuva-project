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
        // GET: api/<MitchzekController>
        [HttpGet]
        public ActionResult Get()
        {
            List<DonationEntity> donations = donationServices.GetAllDonations();
            if (donations == null)
                return NotFound();
            return Ok(donations);
        }
       


        // GET api/<MitchzekController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            DonationEntity donation = donationServices.GetDonationById(id);
            if (donation == null)
                return NotFound();
            return Ok(donation);
        }

        // POST api/<MitchzekController>
        [HttpPost]
        public ActionResult Post([FromBody] DonationEntity value)
        {
            bool isSuccess = donationServices.PostDonation(value);
            return isSuccess ? Ok(true) : NotFound();
        }

        // PUT api/<MitchzekController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] DonationEntity value)
        {
            bool isSuccess = donationServices.PutDonation(id, value);
            return isSuccess ? Ok(true) : NotFound();
        }

        // DELETE api/<MitchzekController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool isSuccess = donationServices.DeleteDonation(id);
            return isSuccess ? Ok(true) : NotFound();
        }
    }
}
