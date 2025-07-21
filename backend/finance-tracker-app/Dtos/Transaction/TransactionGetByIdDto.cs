namespace finance_tracker_app.Dtos.Transaction
{
    public class TransactionGetByIdDto
    {
        // Id of the transaction to be retrieved
        public required int Id { get; set; }

        // Current user ID to ensure the request is made by the correct user
        public required int CurrentUserId { get; set; }
    }
}
