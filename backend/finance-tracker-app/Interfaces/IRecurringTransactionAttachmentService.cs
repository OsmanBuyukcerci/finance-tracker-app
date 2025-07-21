using finance_tracker_app.Dtos.RecurringTransactionAttachment;
using finance_tracker_app.Dtos.Response;

namespace finance_tracker_app.Interfaces
{
    public interface IRecurringTransactionAttachmentService
    {
        public Task<List<RecurringTransactionAttachmentGetDto>> GetByUserIdAsync(RecurringTransactionAttachmentGetByUserIdDto Request);
        public Task<CreateResponseDto> CreateAsync(RecurringTransactionAttachmentCreateDto Request);
        public Task<UpdateResponseDto> UpdateAsync(RecurringTransactionAttachmentUpdateDto Request);
        public Task<DeleteResponseDto> DeleteAsync(RecurringTransactionAttachmentDeleteDto Request);
    }
}
