namespace finance_tracker_app.Dtos.RecurringTransactionAttachment
{
    public class RecurringTransactionAttachmentCreateDto
    {
        public required string FileName { get; set; }
        
        public required string FilePath { get; set; }

        public required int RecurringTransactionId { get; set; }
    }
}
