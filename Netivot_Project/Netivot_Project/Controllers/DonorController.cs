using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Netivot_Project.entities;

namespace Netivot_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonorController : Controller
    {
        DonorServices donorServices = new DonorServices();
        // GET: api/<DonorController>
        [HttpGet]
        public ActionResult<List<DonorEntity>> Get()
        {
            List<DonorEntity> donors = donorServices.GetAllDonors();
            if (donors == null)
                return NotFound();
            return donors;
        }

        // GET api/<DonorController>/5
        [HttpGet("{id}")]
        public ActionResult<DonorEntity> Get(int id)
        {
            DonorEntity donor = donorServices.GetDonorById(id);
            if (donor == null)
                return NotFound();
            return donor;
        }

        // POST api/<DonorController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] DonorEntity value)
        {
            bool isSuccess = donorServices.AddDonor(value);
            return isSuccess ? true : false;
        }

        // PUT api/<DonorController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] DonorEntity value)
        {
            bool isSuccess = donorServices.UpdateDonor(id, value);
            return isSuccess ? true : false;
        }

        // DELETE api/<DonorController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool isSuccess = donorServices.DeleteDonor(id);
            return isSuccess ? true : false;
        }
    }
}
