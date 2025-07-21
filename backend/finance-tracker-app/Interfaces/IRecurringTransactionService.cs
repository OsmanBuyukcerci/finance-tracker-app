using finance_tracker_app.Dtos.RecurringTransaction;
using finance_tracker_app.Dtos.Response;

namespace finance_tracker_app.Interfaces
{
    public interface IRecurringTransactionService
    {
        public Task<List<RecurringTransactionLimitedGetDto>> GetAllAsync();
        public Task<RecurringTransactionGetDto> GetByIdAsync(RecurringTransactionGetByIdDto Request);
        public Task<List<RecurringTransactionGetDto>> GetByUserIdAsync(RecurringTransactionGetByUserIdDto Request);
        public Task<CreateResponseDto> CreateAsync(RecurringTransactionCreateDto Request);
        public Task<UpdateResponseDto> UpdateAsync(RecurringTransactionUpdateDto Request);
        public Task<DeleteResponseDto> DeleteAsync(RecurringTransactionDeleteDto Request);
    }
}