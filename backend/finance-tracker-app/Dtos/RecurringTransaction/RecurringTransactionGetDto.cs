namespace finance_tracker_app.Dtos.RecurringTransaction
{
    public class RecurringTransactionGetDto
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        public required decimal Amount { get; set; }

        public Entities.Frequency Frequency { get; set; }

        public required DateTime StartDate { get; set; }

        public required DateTime EndDate { get; set; }

        public ICollection<Entities.RecurringTransactionAttachment>? Attachments { get; set; }

        public required Entities.Category Category { get; set; }
    }
}
