using Microsoft.AspNetCore.Mvc;
using Netivot.Core.Entities;
using Netivot.Core.Interfaces;

namespace Netivot.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MitchzekController : ControllerBase
    {
        readonly IService<MitchazekEntity> _iService;
        public MitchzekController(IService<MitchazekEntity> iService)
        {
            _iService = iService;
        }           // GET: api/<MitchzekController>
        [HttpGet]
        public ActionResult<List<MitchazekEntity>> Get()
        {
            List<MitchazekEntity> mitchazkim = _iService.GetAll();
            if (mitchazkim == null)
                return NotFound();
            return mitchazkim;
        }

        // GET api/<MitchzekController>/5
        [HttpGet("{id}")]
        public ActionResult<MitchazekEntity> Get(int id)
        {
            MitchazekEntity mitchazek = _iService.GetById(id);
            if (mitchazek == null)
                return NotFound();
            return mitchazek;
        }

        // POST api/<MitchzekController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] MitchazekEntity value)
        {
            bool isSuccess = _iService.Add(value);
            return isSuccess ? true : false;
        }

        // PUT api/<MitchzekController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] MitchazekEntity value)
        {
            bool isSuccess = _iService.Update(id, value);
            return isSuccess ? true : false;
        }

        // DELETE api/<MitchzekController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool isSuccess = _iService.Delete(id);
            return isSuccess ? true : false;
        }
    }
}
