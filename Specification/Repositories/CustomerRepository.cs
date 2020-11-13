using Specification.Models;
using Specification.Rules.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace Specification.Repositories
{
    public class CustomerRepository
    {
        private static IReadOnlyList<Customer> Customers()
        {
            return new List<Customer>()
            {
                new Customer("Fabio 1", "email1@email.com"),
                new Customer("Fabio 2", "email2@email.com"),
                new Customer("Fabio 3", ""),
            };
        }

        public IReadOnlyList<Customer> GetCustomersByRule(IRule<Customer> customerRule)
        {
            return Customers().Where(customerRule.IsSatisfiedBy).ToList();
        }
    }
}
