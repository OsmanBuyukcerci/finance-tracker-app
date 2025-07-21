namespace finance_tracker_app.Dtos.RecurringTransaction
{
    public class RecurringTransactionGetByIdDto
    {
        // Id of the recurring transaction to retrieve
        public required int Id { get; set; }

        // Current user ID to ensure the recurring transaction belongs to the user
        public required int UserId { get; set; }
    }
}
