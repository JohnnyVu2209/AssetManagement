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

    public class MapAssetDTO : Profile
    {
        public MapAssetDTO()
        {
            CreateMap<Asset, AssetDTO>()
                .ForMember(dto => dto.Category, cfg => cfg.MapFrom(ol => ol.Category == null ? string.Empty : ol.Category.Name))
                .ForMember(dto => dto.State, cfg => cfg.MapFrom(ol => ol.State == null ? string.Empty : ol.State.Name))
                .ForMember(dto => dto.Location, cfg => cfg.MapFrom(ol => ol.Location == null ? string.Empty : ol.Location.LocationName));
        }
    }
}
