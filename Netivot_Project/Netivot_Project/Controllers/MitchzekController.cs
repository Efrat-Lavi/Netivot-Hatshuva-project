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
        public ActionResult<List<MitchazekEntity>> Get()
        {
            List<MitchazekEntity> mitchazkim = mitchazekServices.GetAllMitchazkim();
            if (mitchazkim == null)
                return NotFound();
            return mitchazkim;
        }

        // GET api/<MitchzekController>/5
        [HttpGet("{id}")]
        public ActionResult<MitchazekEntity> Get(int id)
        {
            MitchazekEntity mitchazek = mitchazekServices.GetMitchazekById(id);
            if (mitchazek == null)
                return NotFound();
            return mitchazek;
        }

        // POST api/<MitchzekController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] MitchazekEntity value)
        {
            bool isSuccess = mitchazekServices.AddMitchazek(value);
            return isSuccess ? true: false;
        }

        // PUT api/<MitchzekController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] MitchazekEntity value)
        {
            bool isSuccess = mitchazekServices.UpdateMitchazek(id,value);
            return isSuccess ? true : false;
        }

        // DELETE api/<MitchzekController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool isSuccess = mitchazekServices.DeleteMitchazek(id);
            return isSuccess ? true : false;
        }
    }
}
