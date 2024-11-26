using Microsoft.AspNetCore.Mvc;
using Netivot.Core.Entities;
using Netivot.Core.Interfaces;

namespace Netivot.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationController : Controller
    {
        // GET: DonationController
        readonly IService<DonationEntity> _iService;
        public DonationController(IService<DonationEntity> iService)
        {
            _iService = iService;
        }
        // GET: api/<DonationController>
        [HttpGet]
        public ActionResult<List<DonationEntity>> Get()
        {
            List<DonationEntity> donations = _iService.GetAll();
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
            DonationEntity donation = _iService.GetById(id);
            if (donation == null)
                return NotFound();
            return donation;
        }

        // POST api/<DonationController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] DonationEntity value)
        {
            bool isSuccess = _iService.Add(value);
            return isSuccess ? true : false;
        }

        // PUT api/<DonationController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] DonationEntity value)
        {
            bool isSuccess = _iService.Update(id, value);
            return isSuccess ? true : false;
        }

        // DELETE api/<DonationController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool isSuccess = _iService.Delete(id);
            return isSuccess ? true : false;
        }
    }
}
