using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Netivot.Core.Entities;
using Netivot.Core.Interfaces;

namespace Netivot.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvrechController : ControllerBase
    {
        readonly IService<AvrechEntity> _iService;
        public AvrechController(IService<AvrechEntity> iService)
        {
            _iService = iService;
        }
        // GET: api/<AvrechController>
        [HttpGet]
        public ActionResult<List<AvrechEntity>> Get()
        {
            List<AvrechEntity> avrechim = _iService.GetAll();
            if (avrechim == null)
                return NotFound();
            return avrechim;
        }

        // GET api/<AvrechController>/5
        [HttpGet("{id}")]
        public ActionResult<AvrechEntity> Get(int id)
        {
            AvrechEntity mitchazek = _iService.GetById(id);
            if (mitchazek == null)
                return NotFound();
            return mitchazek;
        }

        // POST api/<AvrechController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] AvrechEntity value)
        {
            bool isSuccess = _iService.Add(value);
            return isSuccess ? true : false;
        }

        // PUT api/<AvrechController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] AvrechEntity value)
        {
            bool isSuccess = _iService.Update(id, value);
            return isSuccess ? true : false;
        }

        // DELETE api/<AvrechController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool isSuccess = _iService.Delete(id);
            return isSuccess ? true : false;
        }
    }
}
