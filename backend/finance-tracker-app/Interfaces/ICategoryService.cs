using finance_tracker_app.Dtos.Category;
using finance_tracker_app.Dtos.Response;

namespace finance_tracker_app.Interfaces
{
    public interface ICategoryService
    {
        public Task<List<CategoryGetDto>> GetAllAsync();
        public Task<CreateResponseDto> CreateAsync(CategoryCreateDto request);
        public Task<UpdateResponseDto> UpdateAsync(CategoryUpdateDto request);
        public Task<DeleteResponseDto> DeleteAsync(CategoryDeleteDto request);
    }
}
