using Amazon_DynamoDB_Demo.Contracts;
using System.Runtime.CompilerServices;

namespace Amazon_DynamoDB_Demo.Mappings
{
    public static class CustomerRequestToCustomerMapping
    {
        public static Customer ToCustomer(this CustomerRequest customerRequest){
            return new Customer
            {
                Id = Guid.NewGuid(),
                GitHubUsername = customerRequest.GitHubUsername,
                DateOfBirth = customerRequest.DateOfBirth,
                FullName = customerRequest.FullName,
                Email = customerRequest.Email,
                UpdatedAt = DateTime.UtcNow
            };
        }
    }
}
