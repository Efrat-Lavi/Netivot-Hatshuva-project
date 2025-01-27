using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Netivot.API.PostModels;
using Netivot.Core.Entities;
using Netivot.Core.Interfaces.IServices;

namespace Netivot.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvrechController : ControllerBase
    {
        readonly IAvrechService _iService;
        private readonly IMapper _mapper;

        public AvrechController(IAvrechService iService,IMapper mapper)
        {
            _iService = iService;
            _mapper = mapper;
        }
        // GET: api/<AvrechController>
        [HttpGet]
        public ActionResult<IEnumerable<AvrechDto>> Get()
        {
            var avrechim = _iService.GetAllAvrechim();
            if (avrechim == null)
                return NotFound();
            return Ok(avrechim);
        }

        // GET api/<AvrechController>/5
        [HttpGet("{id}")]
        public ActionResult<AvrechDto> Get(int id)
        {
            AvrechDto avrech = _iService.GetAvrechById(id);
            if (avrech == null)
                return NotFound();
            return avrech;
        }

        // POST api/<AvrechController>
        [HttpPost]
        public ActionResult<AvrechDto> Post([FromBody] AvrechPostModel avrechPostModel)
        {
            AvrechDto avrechDto = _mapper.Map<AvrechDto>(avrechPostModel);
            avrechDto = _iService.AddAvrech(avrechDto);
            if(avrechDto == null)
                return NotFound();
            return Ok(avrechDto);

        }

        // PUT api/<AvrechController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] AvrechPostModel avrechPostModel)
        {
            AvrechDto avrechDto = _mapper.Map<AvrechDto>(avrechPostModel);
            avrechDto = _iService.UpdateAvrech(id, avrechDto);
            if (avrechDto == null)
                return NotFound();
            return Ok(avrechDto);
        }

        // DELETE api/<AvrechController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool isSuccess = _iService.DeleteAvrech(id);
            return isSuccess ? true : false;
        }
    }
}
