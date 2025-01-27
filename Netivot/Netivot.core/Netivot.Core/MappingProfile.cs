using AutoMapper;
using Netivot.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Core
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<AvrechDto, AvrechEntity>().ReverseMap();
            CreateMap<DonationDto, DonationEntity>().ReverseMap();
            CreateMap<DonorDto, DonorEntity>().ReverseMap();
            CreateMap<MeetingDto, MeetingEntity>().ReverseMap();
            CreateMap<MitchazekDto, MitchazekEntity>().ReverseMap();
        }
    }
}
