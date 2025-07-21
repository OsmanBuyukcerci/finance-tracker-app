namespace finance_tracker_app.Dtos.RecurringTransaction
{
    public class RecurringTransactionCreateDto
    {
        public required string Title { get; set; }

        public required decimal Amount { get; set; }

        public required Entities.Frequency Frequency { get; set; }

        public DateTime StartDate { get; set; }

        public ICollection<Entities.RecurringTransactionAttachment>? Attachments { get; set; }

        public required int CategoryId { get; set; }

        public required int UserId { get; set; }
    }
}
