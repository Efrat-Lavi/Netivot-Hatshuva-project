using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Netivot.Core.Entities;
using Netivot.Core.Interfaces;

namespace Netivot.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonorController : Controller
    {
        readonly IService<DonorEntity> _iService;
        public DonorController(IService<DonorEntity> iService)
        {
            _iService = iService;
        }
        // GET: api/<DonorController>
        [HttpGet]
        public ActionResult<List<DonorEntity>> Get()
        {
            List<DonorEntity> donors = _iService.GetAll();
            if (donors == null)
                return NotFound();
            return donors;
        }

        // GET api/<DonorController>/5
        [HttpGet("{id}")]
        public ActionResult<DonorEntity> Get(int id)
        {
            DonorEntity donor = _iService.GetById(id);
            if (donor == null)
                return NotFound();
            return donor;
        }

        // POST api/<DonorController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] DonorEntity value)
        {
            bool isSuccess = _iService.Add(value);
            return isSuccess ? true : false;
        }

        // PUT api/<DonorController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] DonorEntity value)
        {
            bool isSuccess = _iService.Update(id, value);
            return isSuccess ? true : false;
        }

        // DELETE api/<DonorController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool isSuccess = _iService.Delete(id);
            return isSuccess ? true : false;
        }
    }
}
