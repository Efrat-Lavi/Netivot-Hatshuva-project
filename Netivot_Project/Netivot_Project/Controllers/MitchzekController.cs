using Microsoft.AspNetCore.Mvc;
using Netivot_Project.entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Netivot_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MitchzekController : ControllerBase
    {
        MitchazekServices mitchazekServices=new MitchazekServices();
        // GET: api/<MitchzekController>
        [HttpGet]
        public ActionResult Get()
        {
            List<MitchazekEntity> mitchazkim = mitchazekServices.GetAllMitchazkim();
            if (mitchazkim == null)
                return NotFound();
            return Ok(mitchazkim);
        }

        // GET api/<MitchzekController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            MitchazekEntity mitchazek = mitchazekServices.GetMitchazekById(id);
            if (mitchazek == null)
                return NotFound();
            return Ok(mitchazek);
        }

        // POST api/<MitchzekController>
        [HttpPost]
        public ActionResult Post([FromBody] MitchazekEntity value)
        {
            bool isSuccess = mitchazekServices.PostMitchazek(value);
            return isSuccess ? Ok(true):NotFound();
        }

        // PUT api/<MitchzekController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] MitchazekEntity value)
        {
            bool isSuccess = mitchazekServices.PutMitchazek(id,value);
            return isSuccess ? Ok(true) : NotFound();
        }

        // DELETE api/<MitchzekController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool isSuccess = mitchazekServices.DeleteMitchazek(id);
            return isSuccess ? Ok(true) : NotFound();
        }
    }
}
