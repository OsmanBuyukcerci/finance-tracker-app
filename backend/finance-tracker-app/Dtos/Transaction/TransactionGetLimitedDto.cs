namespace finance_tracker_app.Dtos.Transaction
{
    public class TransactionGetLimitedDto
    {
        public required int Id { get; set; }

        public required decimal Amount { get; set; }

        public required DateTime Date { get; set; }

        public required Entities.Category Category { get; set; }
    }
}
