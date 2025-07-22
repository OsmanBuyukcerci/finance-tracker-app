namespace finance_tracker_app.Dtos.Category
{
    public class CategoryUpdateDto
    {
        // Id of the category which is required for update
        public required int Id { get; set; }

        public string? Name { get; set; }
    }
}
