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
    public class DonorController : Controller
    {
        readonly IDonorService _iService;
        private readonly IMapper _mapper;

        public DonorController(IDonorService iService, IMapper mapper)
        {
            _iService = iService;
            _mapper = mapper;
        }
        // GET: api/<DonorController>
        [HttpGet]
        public ActionResult<IEnumerable<DonorDto>> Get()
        {
            var donors = _iService.GetAllDonors();
            if (donors == null)
                return NotFound();
            return Ok(donors);
        }

        // GET api/<DonorController>/5
        [HttpGet("{id}")]
        public ActionResult<DonorDto> Get(int id)
        {
            DonorDto donor = _iService.GetDonorById(id);
            if (donor == null)
                return NotFound();
            return donor;
        }

        // POST api/<DonorController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] DonorPostModel donorPostModel)
        {
            DonorDto donorDto = _mapper.Map<DonorDto>(donorPostModel);
            donorDto = _iService.AddDonor(donorDto);
            if (donorDto == null)
                return NotFound();
            return Ok(donorDto);
        }

        // PUT api/<DonorController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] DonorPostModel donorPostModel)
        {
            DonorDto donorDto = _mapper.Map<DonorDto>(donorPostModel);
            donorDto = _iService.UpdateDonor(id, donorDto);
            if (donorDto == null)
                return NotFound();
            return Ok(donorDto);
        }

        // DELETE api/<DonorController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool isSuccess = _iService.DeleteDonor(id);
            return isSuccess ? true : false;
        }
    }
}
