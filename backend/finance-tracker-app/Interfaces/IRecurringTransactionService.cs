using finance_tracker_app.Dtos.RecurringTransaction;
using finance_tracker_app.Dtos.Response;

namespace finance_tracker_app.Interfaces
{
    public interface IRecurringTransactionService
    {
        public Task<List<RecurringTransactionLimitedGetDto>> GetAllAsync();
        public Task<RecurringTransactionGetDto> GetByIdAsync(RecurringTransactionGetByIdDto request);
        public Task<List<RecurringTransactionGetDto>> GetByUserIdAsync(RecurringTransactionGetByUserIdDto request);
        public Task<CreateResponseDto> CreateAsync(RecurringTransactionCreateDto request);
        public Task<UpdateResponseDto> UpdateAsync(RecurringTransactionUpdateDto request);
        public Task<DeleteResponseDto> DeleteAsync(RecurringTransactionDeleteDto request);
    }
}