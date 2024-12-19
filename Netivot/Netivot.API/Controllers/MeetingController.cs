using Microsoft.AspNetCore.Mvc;
using Netivot.Core.Entities;
using Netivot.Core.Interfaces;

namespace Netivot.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingController : Controller
    {
        // GET: MeetingController
        readonly IMeetingService _iService;
        public MeetingController(IMeetingService iService)
        {
            _iService = iService;
        }        // GET: api/<MeetingController>
        [HttpGet]
        public ActionResult<List<MeetingEntity>> Get()
        {
            List<MeetingEntity> meetings = _iService.GetAllMeetings();
            if (meetings == null)
                return NotFound();
            return meetings;
        }

        // GET api/<MeetingController>/5
        [HttpGet("{id}")]
        public ActionResult<MeetingEntity> Get(int id)
        {
            MeetingEntity meetings = _iService.GetMeetingById(id);
            if (meetings == null)
                return NotFound();
            return meetings;
        }

        // POST api/<MeetingController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] MeetingEntity value)
        {
            bool isSuccess = _iService.AddMeeting(value);
            return isSuccess ? true : false;
        }

        // PUT api/<MeetingController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] MeetingEntity value)
        {
            bool isSuccess = _iService.UpdateMeeting(id, value);
            return isSuccess ? true : false;
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
