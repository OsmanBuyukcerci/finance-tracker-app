using finance_tracker_app.Data;
using finance_tracker_app.Dtos.Category;
using finance_tracker_app.Dtos.Response;
using finance_tracker_app.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace finance_tracker_app.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _Context;

        public CategoryService(AppDbContext context)
        {
            _Context = context;
        }

        public async Task<List<CategoryGetDto>> GetAllAsync()
        {
            List<CategoryGetDto> categories = await _Context.Categories
                .Select(c => new CategoryGetDto
                {
                    Id = c.Id,
                    Name = c.Name
                }).ToListAsync();

            return categories;
        }

        public async Task<CreateResponseDto> CreateAsync(CategoryCreateDto request)
        {
            bool categoryExists = await _Context.Categories.AnyAsync(c => c.Name == request.Name);

            
            var dtoProperties = request.GetType().GetProperties();
            bool dtoInvalid = dtoProperties.Any(p => p.GetValue(request) == null);

            // Check if the category already exists
            // Check if the DTO has any null properties
            if (categoryExists)
            {
                return new CreateResponseDto
                {
                    Status = CreateStatus.AlreadyExists
                };
            } 
            else if (dtoInvalid)
            {
                return new CreateResponseDto
                {
                    Status = CreateStatus.InvalidData
                };
            }

            // Create a new category
            var category = new Entities.Category
            {
                Name = request.Name
            };

            // Add the new category to the database
            // Save changes to the database
            await _Context.Categories.AddAsync(category);
            await _Context.SaveChangesAsync();

            return new CreateResponseDto
            {
                Status = CreateStatus.Success
            };
        }

        public async Task<UpdateResponseDto> UpdateAsync(CategoryUpdateDto request)
        {
            var category = await _Context.Categories.FindAsync(request.Id);

            var dtoProperties = request.GetType().GetProperties();
            bool dtoContainData = dtoProperties.Any(p => p.GetValue(request) != null);

            // Check if the category exists
            // Check if the request has only one property and if the new property is empty
            if (category == null)
            {
                return new UpdateResponseDto
                {
                    Status = UpdateStatus.NotFound
                };
            } 
            else if (!dtoContainData)
            {
                return new UpdateResponseDto
                {
                    Status = UpdateStatus.InvalidData
                };
            }

            var categoryType = category.GetType();

            // Iterate through the properties of the DTO
            foreach (var property in dtoProperties)
            {
                var newValue = property.GetValue(request);

                // Skip null values to avoid overwriting existing values with null
                if (newValue == null)
                {
                    continue; // Skip null values
                }

                var targetProperty = categoryType.GetProperty(property.Name);

                // Check if the target property exists and is writable
                if (targetProperty != null && targetProperty.CanWrite)
                {
                    // Update the property value
                    targetProperty.SetValue(category, newValue);
                }
            }

            // Save changes to the database
            await _Context.SaveChangesAsync();

            return new UpdateResponseDto
            {
                Status = UpdateStatus.Success
            };
        }

        public async Task<DeleteResponseDto> DeleteAsync(CategoryDeleteDto request)
        {
            var category = await _Context.Categories.FindAsync(request.Id);

            if (category == null)
            {
                return new DeleteResponseDto
                {
                    Status = DeleteStatus.NotFound
                };
            }

            // Remove the category from the database
            // Save changes to the database
            _Context.Categories.Remove(category);
            await _Context.SaveChangesAsync();

            return new DeleteResponseDto
            {
                Status = DeleteStatus.Success
            };
        }
    }
}
