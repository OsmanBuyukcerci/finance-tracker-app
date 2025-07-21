namespace finance_tracker_app.Dtos.RecurringTransactionAttachment
{
    public class RecurringTransactionAttachmentGetDto
    {
        public required int Id { get; set; }

        public required string FileName { get; set; }

        public required string FilePath { get; set; }

        public required int RecurringTransactionId { get; set; }
    }
}
