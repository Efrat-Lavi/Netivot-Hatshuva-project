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
        public ActionResult Get()
        {
            List<MeetingEntity> meetings = meetingServices.GetAllMeeting();
            if (meetings == null)
                return NotFound();
            return Ok(meetings);
        }

        // GET api/<MeetingController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            MeetingEntity meetings = meetingServices.GetMeetingById(id);
            if (meetings == null)
                return NotFound();
            return Ok(meetings);
        }

        // POST api/<MeetingController>
        [HttpPost]
        public ActionResult Post([FromBody] MeetingEntity value)
        {
            bool isSuccess = meetingServices.PostMeeting(value);
            return isSuccess ? Ok(true) : NotFound();
        }

        // PUT api/<MeetingController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] MeetingEntity value)
        {
            bool isSuccess = meetingServices.PutMeeting(id, value);
            return isSuccess ? Ok(true) : NotFound();
        }

        // DELETE api/<MeetingController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool isSuccess = meetingServices.DeleteMeeting(id);
            return isSuccess ? Ok(true) : NotFound();
        }
    }
}
