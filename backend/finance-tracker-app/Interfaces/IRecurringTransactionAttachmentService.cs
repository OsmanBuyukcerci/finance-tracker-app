using finance_tracker_app.Dtos.RecurringTransactionAttachment;
using finance_tracker_app.Dtos.Response;

namespace finance_tracker_app.Interfaces
{
    public interface IRecurringTransactionAttachmentService
    {
        public Task<List<RecurringTransactionAttachmentGetDto>> GetByUserIdAsync(RecurringTransactionAttachmentGetByUserIdDto request);
        public Task<CreateResponseDto> CreateAsync(RecurringTransactionAttachmentCreateDto request);
        public Task<UpdateResponseDto> UpdateAsync(RecurringTransactionAttachmentUpdateDto request);
        public Task<DeleteResponseDto> DeleteAsync(RecurringTransactionAttachmentDeleteDto request);
    }
}
