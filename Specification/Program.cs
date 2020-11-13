using Specification.Repositories;
using Specification.Rules.Customer;
using System;
using System.Linq;

namespace Specification
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerRepository = new CustomerRepository();

            var query = new CustomerEmailRule()
                .And(new CustomerNameRule());
           
            customerRepository
                .GetCustomersByRule(query)
                .ToList()
                .ForEach(customer => Console.WriteLine(customer.Name));
        }
    }
}
