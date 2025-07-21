namespace finance_tracker_app.Dtos.Transaction
{
    public class TransactionGetDto
    {
        public required int Id { get; set; }

        public required string Title { get; set; } = string.Empty;

        public required decimal Amount { get; set; }

        public required DateTime Date { get; set; }

        public ICollection<Entities.TransactionAttachment>? Attachments { get; set; }

        public required Entities.Category Category { get; set; }

        public required Entities.User User { get; set; }
    }
}
