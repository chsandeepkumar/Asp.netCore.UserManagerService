using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UserManagementService.Entities;
using UserManagementService.Models;

namespace UserManagementService.Mappers
{
    public class UserMapper : Profile, IUserMapper
    {
        public UserMapper()
        {
            CreateMap<ApplicationUserViewModel, IdentityUser>().ReverseMap();
            CreateMap<ApplicationUserViewModel, ApplicationUser>()
                .IncludeBase<ApplicationUserViewModel, IdentityUser>().ReverseMap();
        }
      public ApplicationUserViewModel FromEntity(IdentityUser applicationUserViewModel)
        {
            return Mapper.Map<IdentityUser, ApplicationUserViewModel>(applicationUserViewModel);
        }

        public IdentityUser ToEntity(ApplicationUserViewModel applicationUserViewModel)
        {
            return Mapper.Map< ApplicationUserViewModel, IdentityUser>(applicationUserViewModel);
        }
    }
}
