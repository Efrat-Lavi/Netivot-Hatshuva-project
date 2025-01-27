using AutoMapper;
using Netivot.API.PostModels;
using Netivot.Core.Entities;

namespace Netivot.API
{
    public class MappgingPostProfile:Profile
    {
        public MappgingPostProfile()
        {
            CreateMap<AvrechPostModel, AvrechDto>();
            CreateMap<DonationPostModel, DonationDto>();
            CreateMap<DonorPostModel, DonorDto>();
            CreateMap<MeetingPostModel, MeetingDto>();
            CreateMap<MitchazekPostModel, MitchazekDto>();
        }
    }
}
