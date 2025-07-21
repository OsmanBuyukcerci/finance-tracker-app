namespace finance_tracker_app.Dtos.TransactionAttachment
{
    public class TransactionAttachmentUpdateDto
    {
        // The ID of the transaction attachment to update
        public required int Id { get; set; }

        // The ID of the transaction to which this attachment belongs
        public required int TransactionId { get; set; }

        public string? FileName { get; set; }

        public string? FilePath { get; set; }
    }
}
