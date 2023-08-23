using AppControleFinanceiro.Models;

namespace AppControleFinanceiro.Repositories
{
    public interface ITransactionRepository
    {
        void Create(Transaction transaction);
        void Delete(Transaction transaction);
        List<Transaction> GetAll();
        void Update(Transaction transaction);
    }
}