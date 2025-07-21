using finance_tracker_app.Dtos.Response;
using finance_tracker_app.Dtos.User;

namespace finance_tracker_app.Interfaces
{
    public interface IUserService
    {
        public Task<List<UserGetLimitedDto>> GetAllAsync();
        public Task<UserGetLimitedDto> GetByEmailAsync(UserGetByEmailDto Request);
        public Task<CreateResponseDto> CreateAsync(UserCreateDto Request);
        public Task<UpdateResponseDto> UpdateAsync(UserUpdateDto Request);
        public Task<UpdatePasswordResponseDto> UpdatePasswordAsync(UserUpdatePasswordDto Request);
        public Task<UpdateResponseDto> UpdateRoleAsync(UserRoleUpdateDto Request);
        public Task<DeleteResponseDto> DeleteAsync(UserDeleteDto Request);
    }
}
