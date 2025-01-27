using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Netivot.API.PostModels;
using Netivot.Core.Entities;
using Netivot.Core.Interfaces.IServices;

namespace Netivot.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationController : Controller
    {
        // GET: DonationController
        private readonly IDonationService _iService;
        private readonly IMapper _mapper;

        public DonationController(IDonationService iService, IMapper mapper)
        {
            _iService = iService;
            _mapper = mapper;
        }
        // GET: api/<DonationController>
        [HttpGet]
        public ActionResult<IEnumerable<DonationDto>> Get()
        {
            var donations = _iService.GetAllDonations();
            if (donations == null)
                return NotFound();
            return Ok(donations);
          
        }

        // GET api/<DonationController>/5
        [HttpGet("{id}")]
        public ActionResult<DonationDto> Get(int id)
        {
            DonationDto donationDto = _iService.GetDonationById(id);
            if (donationDto == null)
                return NotFound();
            return donationDto;
        }

        // POST api/<DonationController>
        [HttpPost]
        public ActionResult<DonationDto> Post([FromBody] DonationPostModel donationPostModel)
        {
            DonationDto donationDto = _mapper.Map<DonationDto>(donationPostModel);
            donationDto = _iService.AddDonation(donationDto);
            if (donationDto == null)
                return NotFound();
            return Ok(donationDto);
        }

        // PUT api/<DonationController>/5
        [HttpPut("{id}")]
        public ActionResult<DonationDto> Put(int id, [FromBody] DonationPostModel donationPostModel)
        {
            DonationDto donationDto = _mapper.Map<DonationDto>(donationPostModel);
            donationDto = _iService.UpdateDonation(id, donationDto);
            if (donationDto == null)
                return NotFound();
            return Ok(donationDto);
        }

        // DELETE api/<DonationController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool isSuccess = _iService.DeleteDonation(id);
            return isSuccess ? true : false;
        }
    }
}
