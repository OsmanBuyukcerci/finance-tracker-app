using finance_tracker_app.Dtos.Response;
using finance_tracker_app.Dtos.User;

namespace finance_tracker_app.Interfaces
{
    public interface IUserService
    {
        public Task<List<UserGetLimitedDto>> GetAllAsync();
        public Task<UserGetLimitedDto> GetByEmailAsync(UserGetByEmailDto request);
        public Task<CreateResponseDto> CreateAsync(UserCreateDto request);
        public Task<UpdateResponseDto> UpdateAsync(UserUpdateDto request);
        public Task<UpdatePasswordResponseDto> UpdatePasswordAsync(UserUpdatePasswordDto request);
        public Task<UpdateResponseDto> UpdateRoleAsync(UserRoleUpdateDto request);
        public Task<DeleteResponseDto> DeleteAsync(UserDeleteDto request);
    }
}
