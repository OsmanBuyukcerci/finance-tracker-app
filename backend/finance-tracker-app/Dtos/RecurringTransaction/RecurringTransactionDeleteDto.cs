namespace finance_tracker_app.Dtos.RecurringTransaction
{
    public class RecurringTransactionDeleteDto
    {
        // Id of recurring transaction which is required for deletion
        public required int Id { get; set; }

        // Current user ID to ensure the recurring transaction belongs to the user
        public required int UserId { get; set; }
    }
}
