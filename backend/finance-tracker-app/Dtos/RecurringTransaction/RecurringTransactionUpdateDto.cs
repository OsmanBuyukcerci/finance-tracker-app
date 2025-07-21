namespace finance_tracker_app.Dtos.RecurringTransaction
{
    public class RecurringTransactionUpdateDto
    {
        // Id of recurring transaction which is required for update
        public required int Id { get; set; }

        // Current user ID to ensure the recurring transaction belongs to the user
        public required int UserId { get; set; }

        public string? Title { get; set; }

        public decimal? Amount { get; set; }

        public Entities.Frequency? Frequency { get; set; }

        public DateTime? StartDate { get; set; }

        public ICollection<Entities.RecurringTransactionAttachment>? Attachments { get; set; }

        public int? CategoryId { get; set; }
    }
}
