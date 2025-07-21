namespace finance_tracker_app.Dtos.RecurringTransaction
{
    public class RecurringTransactionGetByUserIdDto
    {
        // Id of the user whose recurring transactions are to be retrieved
        public required int UserId { get; set; }

        // Current user ID to ensure the request is made by the correct user
        public required int CurrentUserId { get; set; }
    }
}
