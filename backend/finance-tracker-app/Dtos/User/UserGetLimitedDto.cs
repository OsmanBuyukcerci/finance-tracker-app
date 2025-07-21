namespace finance_tracker_app.Dtos.User
{
    public class UserGetLimitedDto
    {
        public required int Id { get; set; }

        public required string Name { get; set; }
        
        public required string Surname { get; set; }

        public required string Email { get; set; }

        public required Entities.UserRole Role { get; set; }
    }
}
