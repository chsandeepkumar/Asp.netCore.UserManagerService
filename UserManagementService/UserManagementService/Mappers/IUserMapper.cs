using UserManagementService.Entities;
using UserManagementService.Models;

namespace UserManagementService.Mappers
{
    public interface IUserMapper
    {
        ApplicationUser ToEntity(ApplicationUserViewModel applicationUserViewModel);
        ApplicationUserViewModel FromEntity(ApplicationUser applicationUserViewModel);
    }
}