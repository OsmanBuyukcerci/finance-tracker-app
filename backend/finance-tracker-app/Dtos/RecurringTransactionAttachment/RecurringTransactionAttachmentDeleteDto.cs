namespace finance_tracker_app.Dtos.RecurringTransactionAttachment
{
    public class RecurringTransactionAttachmentDeleteDto
    {
        // Id of the attachment to be deleted
        public required int Id { get; set; }

        // Id of the recurring transaction to which the attachment belongs
        public required int RecurringTransactionId { get; set; }
    }
}
