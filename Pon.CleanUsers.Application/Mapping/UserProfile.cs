using AutoMapper;
using Pon.CleanUsers.Application.DTOs;
using Pon.CleanUsers.Domain.Entities;

namespace Pon.CleanUsers.Application.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<CreateUserDto, User>();
            CreateMap<UpdateUserDto, User>();
        }
    }
}
