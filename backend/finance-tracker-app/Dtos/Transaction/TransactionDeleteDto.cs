namespace finance_tracker_app.Dtos.Transaction
{
    public class TransactionDeleteDto
    {
        // Id of transaction which is required for deletion
        public required int Id { get; set; }

        // Current user ID to ensure the transaction belongs to the user
        public required int UserId { get; set; }
    }
}
