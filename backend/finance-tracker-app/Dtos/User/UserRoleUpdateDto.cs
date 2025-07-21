namespace finance_tracker_app.Dtos.User
{
    public class UserRoleUpdateDto
    {
        // Id of the user whose role is to be updated
        public required int Id { get; set; }

        public required Entities.UserRole Role { get; set; }
    }
}
