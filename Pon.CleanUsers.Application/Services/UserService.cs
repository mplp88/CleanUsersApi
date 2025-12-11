using AutoMapper;
using Pon.CleanUsers.Application.DTOs;
using Pon.CleanUsers.Application.Interfaces;
using Pon.CleanUsers.Domain.Entities;


namespace Pon.CleanUsers.Application.Services
{
    public class UserService(IUserRepository repository, IMapper mapper) : IUserService
    {
        public async Task<List<UserDto>> GetAllAsync()
        {
            var users = await repository.GetAllAsync();
            return mapper.Map<List<UserDto>>(users);
        }

        public async Task<UserDto?> GetByIdAsync(int id)
        {
            var user = await repository.GetByIdAsync(id);
            return user == null ? null : mapper.Map<UserDto>(user);
        }

        public async Task<UserDto> CreateAsync(CreateUserDto dto)
        {
            var user = mapper.Map<User>(dto);
            var created = await repository.AddAsync(user);
            return mapper.Map<UserDto>(created);
        }

        public async Task<UserDto?> UpdateAsync(int id, UpdateUserDto dto)
        {
            var user = await repository.GetByIdAsync(id);
            if(user == null)
                return null;

            mapper.Map(dto, user);
            await repository.UpdateAsync(user);

            return mapper.Map<UserDto>(user);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var user = await repository.GetByIdAsync(id);
            if(user == null)
                return false;

            await repository.DeleteAsync(user);
            return true;
        }
    }
}
