using WebApiMasterTemplate.Domain.DbModels;
using AutoMapper;
using WebApiMasterTemplate.Web.FormModels;

namespace WebApiMasterTemplate.Web.Mappers
{
  public class UserMapper : Profile
  {
    public UserMapper()
    {
      CreateMap<UserLoginModel, User>()
        .ForMember(dest => dest.Id, src => src.Ignore())
        .ForMember(dest => dest.TaskTrackers, src => src.Ignore());

      CreateMap<UserRegistrationModel, User>()
        .ForMember(dest => dest.Id, src => src.Ignore())
        .ForMember(dest => dest.TaskTrackers, src => src.Ignore());
    }
  }
}
