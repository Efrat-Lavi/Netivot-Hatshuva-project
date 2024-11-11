using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Netivot_Project.entities;

namespace Netivot_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingController : Controller
    {
        // GET: MeetingController
        MeetingServices meetingServices = new MeetingServices();
        // GET: api/<MeetingController>
        [HttpGet]
        public ActionResult<List<MeetingEntity>> Get()
        {
            List<MeetingEntity> meetings = meetingServices.GetAllMeeting();
            if (meetings == null)
                return NotFound();
            return meetings;
        }

        // GET api/<MeetingController>/5
        [HttpGet("{id}")]
        public ActionResult<MeetingEntity> Get(int id)
        {
            MeetingEntity meetings = meetingServices.GetMeetingById(id);
            if (meetings == null)
                return NotFound();
            return meetings;
        }

        // POST api/<MeetingController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] MeetingEntity value)
        {
            bool isSuccess = meetingServices.AddMeeting(value);
            return isSuccess ? true : false;
        }

        // PUT api/<MeetingController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] MeetingEntity value)
        {
            bool isSuccess = meetingServices.UpdateMeeting(id, value);
            return isSuccess ? true : false;
        }

        // DELETE api/<MeetingController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool isSuccess = meetingServices.DeleteMeeting(id);
            return isSuccess ? true : false;
        }
    }
}
