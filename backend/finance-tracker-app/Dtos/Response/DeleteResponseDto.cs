namespace finance_tracker_app.Dtos.Response
{
    public class DeleteResponseDto
    {
        public DeleteStatus Status { get; set; }
    }

    public enum DeleteStatus
    {
        Success,
        NotFound
    }
}
