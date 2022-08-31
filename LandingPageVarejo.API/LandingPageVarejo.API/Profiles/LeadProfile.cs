using AutoMapper;
using LandingPageVarejo.API.DTOS;
using LandingPageVarejo.API.Models;

namespace LandingPageVarejo.API.Profiles
{
    public class LeadProfile : Profile
    {
        public LeadProfile()
        {
            CreateMap<CreateLeadDTO, Lead>();
            CreateMap<Lead, ReadLeadDTO>();
            CreateMap<UpdateLeadDTO, Lead>();

        }
    }
}
