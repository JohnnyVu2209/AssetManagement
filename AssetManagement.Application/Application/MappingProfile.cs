using AssetManagement.Contracts.Request;
using AssetManagement.Contracts.ViewModels;
using AssetManagement.Domain.Model;
using AutoMapper;

namespace AssetManagement.Application.Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserViewModel>();
        }
    }
}
