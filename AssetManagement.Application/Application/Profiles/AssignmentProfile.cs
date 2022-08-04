using AssetManagement.Contracts.ViewModels;
using AssetManagement.Domain.Model;
using AssetManagement.Contracts.AssignmentDTO;
using AutoMapper;

namespace AssetManagement.Application.Application
{
    public class AssignmentProfile : Profile
    {
        public AssignmentProfile()
        {
            CreateMap<Assignment, AssignmentDTO>();
            CreateMap<AssignmentDTO, Assignment>();
                //.ForMember(d => d.AssignmentState, opt => opt.MapFrom(s => s.AssignmentState == 1 ? true : false));
        }
    }


}
