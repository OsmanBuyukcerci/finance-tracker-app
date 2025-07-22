using finance_tracker_app.Dtos.Response;
using finance_tracker_app.Dtos.Transaction;

namespace finance_tracker_app.Interfaces
{
    public interface ITransactionService
    {
        public Task<List<TransactionGetLimitedDto>> GetAllAsync();
        public Task<TransactionGetDto> GetByIdAsync(TransactionGetByIdDto request);
        public Task<List<TransactionGetDto>> GetByUserIdAsync(TransactionGetByUserIdDto request);
        public Task<CreateResponseDto> CreateAsync(TransactionCreateDto request);
        public Task<UpdateResponseDto> UpdateAsync(TransactionUpdateDto request);
        public Task<DeleteResponseDto> DeleteAsync(TransactionDeleteDto request);
    }
}
