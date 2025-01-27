using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Netivot.API.PostModels;
using Netivot.Core.Entities;
using Netivot.Core.Interfaces.IServices;

namespace Netivot.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingController : Controller
    {
        // GET: MeetingController
        readonly IMeetingService _iService;
        private readonly IMapper _mapper;

        public MeetingController(IMeetingService iService, IMapper mapper)
        {
            _iService = iService;
            _mapper = mapper;
        }       // GET: api/<MeetingController>
        [HttpGet]
        public ActionResult<IEnumerable<MeetingDto>> Get()
        {
            var meetings = _iService.GetAllMeetings();
            if (meetings == null)
                return NotFound();
            return Ok(meetings);
        }

        // GET api/<MeetingController>/5
        [HttpGet("{id}")]
        public ActionResult<MeetingDto> Get(int id)
        {
            MeetingDto meetings = _iService.GetMeetingById(id);
            if (meetings == null)
                return NotFound();
            return meetings;
        }

        // POST api/<MeetingController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] MeetingPostModel meetingPostModel)
        {
            MeetingDto meetingDto = _mapper.Map<MeetingDto>(meetingPostModel);
            meetingDto = _iService.AddMeeting(meetingDto);
            if (meetingDto == null)
                return NotFound();
            return Ok(meetingDto);
        }

        // PUT api/<MeetingController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] MeetingPostModel meetingPostModel)
        {
            MeetingDto meetingDto = _mapper.Map<MeetingDto>(meetingPostModel);
            meetingDto = _iService.UpdateMeeting(id, meetingDto);
            if (meetingDto == null)
                return NotFound();
            return Ok(meetingDto);
        }

        // DELETE api/<MeetingController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool isSuccess = _iService.DeleteMeeting(id);
            return isSuccess ? true : false;
        }
    }
}
