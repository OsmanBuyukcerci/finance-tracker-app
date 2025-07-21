namespace finance_tracker_app.Dtos.User
{
    public class UserUpdateDto
    {
        // Id of the user to be updated
        public required int Id { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? Email { get; set; }
    }
}
