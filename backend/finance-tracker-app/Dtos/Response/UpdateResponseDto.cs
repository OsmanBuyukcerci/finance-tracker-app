namespace finance_tracker_app.Dtos.Response
{
    public class UpdateResponseDto
    {
        public UpdateStatus Status { get; set; }
    }

    public enum UpdateStatus
    {
        Success,
        NotFound,
        InvalidData,
        Unauthorized
    }
}
