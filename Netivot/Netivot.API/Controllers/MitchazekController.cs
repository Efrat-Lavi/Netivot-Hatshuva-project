using Microsoft.AspNetCore.Mvc;
using Netivot.Core.Entities;
using Netivot.Core.Interfaces;

namespace Netivot.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MitchzekController : ControllerBase
    {
        readonly IMitchazekService _iService;
        public MitchzekController(IMitchazekService iService)
        {
            _iService = iService;
        }           // GET: api/<MitchzekController>
        [HttpGet]
        public ActionResult<List<MitchazekEntity>> Get()
        {
            List<MitchazekEntity> mitchazkim = _iService.GetAllMitchazkim();
            if (mitchazkim == null)
                return NotFound();
            return mitchazkim;
        }

        // GET api/<MitchzekController>/5
        [HttpGet("{id}")]
        public ActionResult<MitchazekEntity> Get(int id)
        {
            MitchazekEntity mitchazek = _iService.GetMitchazekById(id);
            if (mitchazek == null)
                return NotFound();
            return mitchazek;
        }

        // POST api/<MitchzekController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] MitchazekEntity value)
        {
            bool isSuccess = _iService.AddMitchazek(value);
            return isSuccess ? true : false;
        }

        // PUT api/<MitchzekController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] MitchazekEntity value)
        {
            bool isSuccess = _iService.UpdateMitchazek(id, value);
            return isSuccess ? true : false;
        }

        // DELETE api/<MitchzekController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool isSuccess = _iService.DeleteMitchazek(id);
            return isSuccess ? true : false;
        }
    }
}
