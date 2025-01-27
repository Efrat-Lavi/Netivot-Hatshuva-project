using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Netivot.API.PostModels;
using Netivot.Core.Entities;
using Netivot.Core.Interfaces.IServices;

namespace Netivot.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MitchzekController : ControllerBase
    {
        readonly IMitchazekService _iService;
        private readonly IMapper _mapper;

        public MitchzekController(IMitchazekService iService, IMapper mapper)
        {
            _iService = iService;
            _mapper = mapper;
        }         // GET: api/<MitchzekController>
        [HttpGet]
        public ActionResult<List<MitchazekEntity>> Get()
        {
            var mitchazkim = _iService.GetAllMitchazkim();
            if (mitchazkim == null)
                return NotFound();
            return Ok(mitchazkim);
        }

        // GET api/<MitchzekController>/5
        [HttpGet("{id}")]
        public ActionResult<MitchazekDto> Get(int id)
        {
            MitchazekDto mitchazek = _iService.GetMitchazekById(id);
            if (mitchazek == null)
                return NotFound();
            return mitchazek;
        }

        // POST api/<MitchzekController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] MitchazekPostModel mitchazekPostModel)
        {
            MitchazekDto mitchazekDto = _mapper.Map<MitchazekDto>(mitchazekPostModel);
            mitchazekDto = _iService.AddMitchazek(mitchazekDto);
            if (mitchazekDto == null)
                return NotFound();
            return Ok(mitchazekDto);
        }

        // PUT api/<MitchzekController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] MitchazekPostModel mitchazekPostModel)
        {
            MitchazekDto mitchazekDto = _mapper.Map<MitchazekDto>(mitchazekPostModel);
            mitchazekDto = _iService.UpdateMitchazek(id, mitchazekDto);
            if (mitchazekDto == null)
                return NotFound();
            return Ok(mitchazekDto);
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
