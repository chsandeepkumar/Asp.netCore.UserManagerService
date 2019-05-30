using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UserManagementService.Entities;
using UserManagementService.Models;

namespace UserManagementService.Mappers
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<ApplicationUserViewModel, IdentityUser>().ReverseMap();
            CreateMap<ApplicationUserViewModel, ApplicationUser>()
                .IncludeBase<ApplicationUserViewModel, IdentityUser>().ReverseMap();
        }
     
    }
}
