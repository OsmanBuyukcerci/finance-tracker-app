using finance_tracker_app.Dtos.Response;
using finance_tracker_app.Dtos.TransactionAttachment;

namespace finance_tracker_app.Interfaces
{
    public interface ITransactionAttachmentService
    {
        public Task<List<TransactionAttachmentGetDto>> GetByUserIdAsync(TransactionAttachmentGetByUserIdDto request);
        public Task<CreateResponseDto> CreateAsync(TransactionAttachmentCreateDto request);
        public Task<UpdateResponseDto> UpdateAsync(TransactionAttachmentUpdateDto request);
        public Task<DeleteResponseDto> DeleteAsync(TransactionAttachmentDeleteDto request);
    }
}
