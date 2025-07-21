using finance_tracker_app.Dtos.Category;
using finance_tracker_app.Dtos.Response;

namespace finance_tracker_app.Interfaces
{
    public interface ICategoryService
    {
        public Task<List<CategoryGetDto>> GetAllAsync();
        public Task<CreateResponseDto> CreateAsync(CategoryCreateDto Request);
        public Task<UpdateResponseDto> UpdateAsync(CategoryUpdateDto Request);
        public Task<DeleteResponseDto> DeleteAsync(CategoryDeleteDto Request);
    }
}
