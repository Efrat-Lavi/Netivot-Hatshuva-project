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
        readonly DonationServices _donationService;
        public DonationController(DonationServices donationService)
        {
            _donationService = donationService;
        }
        // GET: api/<DonationController>
        [HttpGet]
        public ActionResult<List<DonationEntity>> Get()
        {
            List<DonationEntity> donations = _donationService.GetAllDonations();
            if (donations == null)
                Console.WriteLine("***");
            //if (donations == null)
            //    return NotFound();
            return donations;
        }
    


        // GET api/<DonationController>/5
        [HttpGet("{id}")]
        public ActionResult<DonationEntity> Get(int id)
        {
            DonationEntity donation = _donationService.GetDonationById(id);
            if (donation == null)
                return NotFound();
            return donation;
        }

        // POST api/<DonationController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] DonationEntity value)
        {
            bool isSuccess = _donationService.AddDonation(value);
            return isSuccess ? true : false;
        }

        // PUT api/<DonationController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] DonationEntity value)
        {
            bool isSuccess = _donationService.UpdateDonation(id, value);
            return isSuccess ? true : false;
        }

        // DELETE api/<DonationController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool isSuccess = _donationService.DeleteDonation(id);
            return isSuccess ? true : false;
        }
    }
}
