namespace finance_tracker_app.Dtos.TransactionAttachment
{
    public class TransactionAttachmentGetDto
    {
        public required int Id { get; set; }
        
        public required string FileName { get; set; }

        public required string FilePath { get; set; }

        public required int TransactionId { get; set; }
    }
}
