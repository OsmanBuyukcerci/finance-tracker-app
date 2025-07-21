namespace finance_tracker_app.Dtos.Transaction
{
    public class TransactionGetByUserIdDto
    {
        // Id of the user for whom transactions are being requested
        public required int UserId { get; set; }

        // Current user ID to ensure the request is made by the correct user
        public required int CurrentUserId { get; set; }
    }
}
