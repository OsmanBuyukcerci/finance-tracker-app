namespace finance_tracker_app.Dtos.Category
{
    public class CategoryDeleteDto
    {
        // Id of the category which is required for deletion
        public required int Id { get; set; }

        // UserId is required to check if the user is Admin
        public required int UserId { get; set; }
    }
}
