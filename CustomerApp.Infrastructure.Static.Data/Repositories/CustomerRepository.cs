using System.Collections.Generic;
using CustomerApp.Core.DomainService;
using CustomerApp.Core.Entity;

namespace CustomerApp.Infrastructure.Static.Data.Repositories
{
    public class CustomerRepository: ICustomerRepository
    {

        public CustomerRepository()
        {
            if (FakeDB.Customers.Count >= 1) return;


            var cust1 = new Customer()
            {
                FirstName = "Bob",
                LastName = "Dylan",
                Address = "BongoStreet 202"
            };
            FakeDB.Customers.Add(cust1);

            var cust2 = new Customer()
            {
                FirstName = "Lars",
                LastName = "Bilde",
                Address = "Ostestrasse 202"
            };
            FakeDB.Customers.Add(cust2);
        }

        public Customer Create(Customer customer)
        {
            customer.Id = id++;
            _customers.Add(customer);

            return customer;
        }

        public IEnumerable<Customer> ReadAll()
        {
            return _customers;
        }

        public Customer ReadById(int id)
        {
            foreach (var customer in _customers)
            {
                if (customer.Id == id)
                {
                    return customer;
                }
            }

            return null;
        }

        // Remove later when we use UOW
        public Customer Update(Customer customerUpdate)
        {
            var customerFromDb = this.ReadById(customerUpdate.Id);

            if (customerFromDb != null)
            {
                customerFromDb.FirstName = customerUpdate.FirstName;
                customerFromDb.LastName = customerUpdate.LastName;
                customerFromDb.Address = customerUpdate.Address;

                return customerFromDb;
            }

            return null;
        }

        public Customer Delete(int id)
        {
            var customerFound = this.ReadById(id);

            if (customerFound != null)
            {
                _customers.Remove(customerFound);

                return customerFound;
            }

            return null;
        }



    }
}
