using AssetManagement.Contracts.UserDTO;
using AssetManagement.Domain.Model;
using AutoMapper;

namespace AssetManagement.Application
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateUserDTO, User>()
                .ForMember(d => d.SecurityStamp, opt => opt.MapFrom(s => Guid.NewGuid().ToString()))
                .ForMember(d => d.Gender, opt => opt.MapFrom(s => s.Gender == 1 ? true : false)); 
        }
    }
}
