namespace finance_tracker_app.Dtos.User
{
    public class UserGetByEmailDto
    {
        public required string Email { get; set; }

        // Id of the user to check account belongs to
        public required int UserId { get; set; }
        }
}
