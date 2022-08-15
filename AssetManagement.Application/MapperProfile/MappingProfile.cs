using AssetManagement.Contracts.AssetDTO;
using AssetManagement.Contracts.AssignmentDTO;
using AssetManagement.Contracts.ReturnRequestDTO;
using AssetManagement.Contracts.Constant;
using AssetManagement.Contracts.UserDTO;
using AssetManagement.Domain.Model;
using AutoMapper;

namespace AssetManagement.Application.MapperProfile
{
    public class MapUserDTOs : Profile
    {
        public MapUserDTOs()
        {
            CreateMap<User, UserViewDTO>()
                .ForMember(d => d.Type, opt => opt.MapFrom(s => s.UserRoles.Where(x => x.UserId == s.Id).FirstOrDefault().RoleId == 1 ? RoleConstant.Admin : RoleConstant.User ))
                .ForMember(d => d.TypeId, opt => opt.MapFrom(s => s.UserRoles.Where(x => x.UserId == s.Id).FirstOrDefault().RoleId));
            CreateMap<CreateUserDTO, User>()
                .ForMember(d => d.SecurityStamp, opt => opt.MapFrom(s => Guid.NewGuid().ToString()))
                .ForMember(d => d.Gender, opt => opt.MapFrom(s => s.Gender == 1))
                .ForMember(d => d.FullName, opt => opt.MapFrom(s => $"{s.FirstName.Trim()} {s.LastName.Trim()}")); 
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

            CreateMap<EditAssetDTO, Asset>();
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
    public class AssignmentProfile : Profile
    {
        public AssignmentProfile()
        {
            CreateMap<Assignment, AssignmentDTO>().ForMember(d => d.Specification, opt => opt.MapFrom(s => s.Asset.Specification));
            CreateMap<AssignmentDTO, Assignment>();
            CreateMap<CreateAssignmentDTO, Assignment>()
                .ForMember(d => d.AssignedToId, opt => opt.MapFrom(s => s.UserId));
            //.ForMember(d => d.AssignmentState, opt => opt.MapFrom(s => s.AssignmentState == 1 ? true : false));
        }
    }

    public class ReturnRequestProfile : Profile
    {
        public ReturnRequestProfile()
        {
            CreateMap<ReturnRequest, ReturnRequestDTO>()
            .ForMember(d => d.AssetCode, opt => opt.MapFrom(s => s.Asset.Code))
            .ForMember(d => d.AssetName, opt => opt.MapFrom(s => s.Asset.Name));
            CreateMap<ReturnRequestDTO, ReturnRequest>();
        }
    }
}
