﻿using AssetManagement.Contracts.AssetDTO;
using AssetManagement.Contracts.UserDTO;
using AssetManagement.Domain.Model;
using AutoMapper;

namespace AssetManagement.Application.MapperProfile
{
    public class MapUserDTOs : Profile
    {
        public MapUserDTOs()
        {
            CreateMap<User, UserViewDTO>();
            CreateMap<CreateUserDTO, User>()
                .ForMember(d => d.SecurityStamp, opt => opt.MapFrom(s => Guid.NewGuid().ToString()))
                .ForMember(d => d.Gender, opt => opt.MapFrom(s => s.Gender == 1 ? true : false)); 
        }
    }

    public class MapAssetDTOs : Profile
    {
        public MapAssetDTOs()
        {
            CreateMap<Asset, AssetDTO>()
                .ForMember(dto => dto.Category, cfg => cfg.MapFrom(ol => ol.Category == null ? string.Empty : ol.Category.Name))
                .ForMember(dto => dto.State, cfg => cfg.MapFrom(ol => ol.State == null ? string.Empty : ol.State.Name))
                .ForMember(dto => dto.Location, cfg => cfg.MapFrom(ol => ol.Location == null ? string.Empty : ol.Location.LocationName));
            
            CreateMap<Asset, AssetDetailDTO>()
                .IncludeBase<Asset, AssetDTO>();
        }
    }

    public class MapCategoryDTOs: Profile
    {
        public MapCategoryDTOs()
        {
            CreateMap<Category, AssetCategoryDTO>();
        }
    }

    public class MapStateDTOs: Profile
    {
        public MapStateDTOs()
        {
            CreateMap<State, AssetStateDTO>();
        }
    }
}