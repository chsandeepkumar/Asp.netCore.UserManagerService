using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UserManagementService.Entities;
using UserManagementService.Models;

namespace UserManagementService.Mappers
{
    public interface IUserMapper 
    {
        IdentityUser ToEntity(ApplicationUserViewModel applicationUserViewModel);
        ApplicationUserViewModel FromEntity(IdentityUser applicationUserViewModel);
    }
}