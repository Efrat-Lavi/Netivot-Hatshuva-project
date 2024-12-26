using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Netivot.Core.Entities;
using Netivot.Core.Interfaces.IServices;

namespace Netivot.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonorController : Controller
    {
        readonly IDonorService _iService;
        public DonorController(IDonorService iService)
        {
            _iService = iService;
        }
        // GET: api/<DonorController>
        [HttpGet]
        public ActionResult<List<DonorEntity>> Get()
        {
            List<DonorEntity> donors = _iService.GetAllDonors();
            if (donors == null)
                return NotFound();
            return donors;
        }

        // GET api/<DonorController>/5
        [HttpGet("{id}")]
        public ActionResult<DonorEntity> Get(int id)
        {
            DonorEntity donor = _iService.GetDonorById(id);
            if (donor == null)
                return NotFound();
            return donor;
        }

        // POST api/<DonorController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] DonorEntity value)
        {
            bool isSuccess = _iService.AddDonor(value);
            return isSuccess ? true : false;
        }

        // PUT api/<DonorController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] DonorEntity value)
        {
            bool isSuccess = _iService.UpdateDonor(id, value);
            return isSuccess ? true : false;
        }

        // DELETE api/<DonorController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool isSuccess = _iService.DeleteDonor(id);
            return isSuccess ? true : false;
        }
    }
}
