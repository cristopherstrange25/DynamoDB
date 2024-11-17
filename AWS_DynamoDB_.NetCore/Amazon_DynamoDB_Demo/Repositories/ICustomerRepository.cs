using Amazon_DynamoDB_Demo.Contracts;

namespace Amazon_DynamoDB_Demo.Repositories
{
    public interface ICustomerRepository
    {
        Task<bool> CreateAsync(Customer customer);

        Task<Customer?> GetAsync(Guid id);

        Task<IEnumerable<Customer>> GetAllAsync();

        Task<bool> UpdateAsync(Customer customer);

        Task<bool> DeleteAsync(Guid id);
    }
}
