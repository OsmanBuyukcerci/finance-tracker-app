namespace finance_tracker_app.Dtos.Response
{
    public class CreateResponseDto
    {
        public CreateStatus Status { get; set; }
    }

    public enum CreateStatus
    {
        Success,
        AlreadyExists,
        InvalidData,
        Unauthorized,
        ServerError
    }
}
