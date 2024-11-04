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
        // GET: api/<MitchzekController>
        [HttpGet]
        public ActionResult Get()
        {
            List<DonorEntity> donors = donorServices.GetAllDonors();
            if (donors == null)
                return NotFound();
            return Ok(donors);
        }

        // GET api/<MitchzekController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            DonorEntity donor = donorServices.GetDonorById(id);
            if (donor == null)
                return NotFound();
            return Ok(donor);
        }

        // POST api/<MitchzekController>
        [HttpPost]
        public ActionResult Post([FromBody] DonorEntity value)
        {
            bool isSuccess = donorServices.PostDonor(value);
            return isSuccess ? Ok(true) : NotFound();
        }

        // PUT api/<MitchzekController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] DonorEntity value)
        {
            bool isSuccess = donorServices.PutDonor(id, value);
            return isSuccess ? Ok(true) : NotFound();
        }

        // DELETE api/<MitchzekController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool isSuccess = donorServices.DeleteDonor(id);
            return isSuccess ? Ok(true) : NotFound();
        }
    }
}
