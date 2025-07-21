namespace finance_tracker_app.Dtos.RecurringTransactionAttachment
{
    public class RecurringTransactionAttachmentUpdateDto
    {
        // Id of the attachment to be updated
        public required int Id { get; set; }

        // Id of the recurring transaction to which the attachment belongs
        public required int RecurringTransactionId { get; set; }

        public string? FileName { get; set; }

        public string? FilePath { get; set; }
    }
}
