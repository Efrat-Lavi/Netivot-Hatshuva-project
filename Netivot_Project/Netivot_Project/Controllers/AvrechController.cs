using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Netivot_Project.entities;

namespace Netivot_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvrechController : ControllerBase
    {
        AvrechServices avrechServices = new AvrechServices();
        // GET: api/<AvrechController>
        [HttpGet]
        public ActionResult<List<AvrechEntity>> Get()
        {
            List<AvrechEntity> avrechim = avrechServices.GetAllAvrechim();
            if (avrechim == null)
                return NotFound();
            return avrechim;
        }

        // GET api/<AvrechController>/5
        [HttpGet("{id}")]
        public ActionResult<AvrechEntity> Get(int id)
        {
            AvrechEntity mitchazek = avrechServices.GetAvrechById(id);
            if (mitchazek == null)
                return NotFound();
            return mitchazek;
        }

        // POST api/<AvrechController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] AvrechEntity value)
        {
            bool isSuccess = avrechServices.AddAvrech(value);
            return isSuccess ? true : false;
        }

        // PUT api/<AvrechController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] AvrechEntity value)
        {
            bool isSuccess = avrechServices.UpdateAvrech(id, value);
            return isSuccess ? true : false;
        }

        // DELETE api/<AvrechController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool isSuccess = avrechServices.DeleteAvrech(id);
            return isSuccess ? true : false;
        }
    }
}
