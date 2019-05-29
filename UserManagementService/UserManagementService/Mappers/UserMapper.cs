using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper;
using UserManagementService.Entities;
using UserManagementService.Models;

namespace UserManagementService.Mappers
{
    public class UserMapper : Profile, IUserMapper
    {
        public ApplicationUserViewModel FromEntity(ApplicationUser applicationUserViewModel)
        {
            return Mapper.Map<ApplicationUser, ApplicationUserViewModel>(applicationUserViewModel);
        }

        public ApplicationUser ToEntity(ApplicationUserViewModel applicationUserViewModel)
        {
            return Mapper.Map< ApplicationUserViewModel,ApplicationUser>(applicationUserViewModel);
        }
    }
}
