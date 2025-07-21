namespace finance_tracker_app.Dtos.Transaction
{
    public class TransactionCreateDto
    {
        public required string Title { get; set; }

        public required decimal Amount { get; set; }

        public required DateTime Date { get; set; }

        public ICollection<Entities.TransactionAttachment>? Attachments { get; set; }

        public required int CategoryId { get; set; }

        public required int UserId { get; set; }
    }
}
