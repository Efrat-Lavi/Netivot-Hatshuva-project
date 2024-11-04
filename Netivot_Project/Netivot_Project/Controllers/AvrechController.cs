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
        // GET: api/<MitchzekController>
        [HttpGet]
        public ActionResult Get()
        {
            List<AvrechEntity> avrechim = avrechServices.GetAllAvrechim();
            if (avrechim == null)
                return NotFound();
            return Ok(avrechim);
        }

        // GET api/<MitchzekController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            AvrechEntity mitchazek = avrechServices.GetAvrechById(id);
            if (mitchazek == null)
                return NotFound();
            return Ok(mitchazek);
        }

        // POST api/<MitchzekController>
        [HttpPost]
        public ActionResult Post([FromBody] AvrechEntity value)
        {
            bool isSuccess = avrechServices.PostAvrech(value);
            return isSuccess ? Ok(true) : NotFound();
        }

        // PUT api/<MitchzekController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] AvrechEntity value)
        {
            bool isSuccess = avrechServices.PutAvrech(id, value);
            return isSuccess ? Ok(true) : NotFound();
        }

        // DELETE api/<MitchzekController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool isSuccess = avrechServices.DeleteAvrech(id);
            return isSuccess ? Ok(true) : NotFound();
        }
    }
}
