namespace finance_tracker_app.Dtos.Transaction
{
    public class TransactionUpdateDto
    {
        // Id of transaction which is required for update
        public required int Id { get; set; }

        // Current user ID to ensure the transaction belongs to the user
        public int UserId { get; set; }

        public string? Title { get; set; }

        public decimal? Amount { get; set; }

        public DateTime? Date { get; set; }

        public ICollection<Entities.TransactionAttachment>? Attachments { get; set; }

        public int? CategoryId { get; set; }
    }
}
