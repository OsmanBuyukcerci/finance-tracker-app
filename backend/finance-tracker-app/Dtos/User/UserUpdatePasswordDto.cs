namespace finance_tracker_app.Dtos.User
{
    public class UserUpdatePasswordDto
    {
        // Id of the user whose password is to be updated
        public required int UserId { get; set; }

        public required string OldPassword { get; set; }

        public required string NewPassword { get; set; }
    }
}