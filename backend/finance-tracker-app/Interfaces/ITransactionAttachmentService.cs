using finance_tracker_app.Dtos.Response;
using finance_tracker_app.Dtos.TransactionAttachment;

namespace finance_tracker_app.Interfaces
{
    public interface ITransactionAttachmentService
    {
        public Task<List<TransactionAttachmentGetDto>> GetByUserIdAsync(TransactionAttachmentGetByUserIdDto Request);
        public Task<CreateResponseDto> CreateAsync(TransactionAttachmentCreateDto Request);
        public Task<UpdateResponseDto> UpdateAsync(TransactionAttachmentUpdateDto Request);
        public Task<DeleteResponseDto> DeleteAsync(TransactionAttachmentDeleteDto Request);
    }
}
