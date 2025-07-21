using finance_tracker_app.Dtos.Response;
using finance_tracker_app.Dtos.Transaction;

namespace finance_tracker_app.Interfaces
{
    public interface ITransactionService
    {
        public Task<List<TransactionGetLimitedDto>> GetAllAsync();
        public Task<TransactionGetDto> GetByIdAsync(TransactionGetByIdDto Request);
        public Task<List<TransactionGetDto>> GetByUserIdAsync(TransactionGetByUserIdDto Request);
        public Task<CreateResponseDto> CreateAsync(TransactionCreateDto Request);
        public Task<UpdateResponseDto> UpdateAsync(TransactionUpdateDto Request);
        public Task<DeleteResponseDto> DeleteAsync(TransactionDeleteDto Request);
    }
}
