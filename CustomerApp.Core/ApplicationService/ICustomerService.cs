using CustomerApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerApp.Core.ApplicationService
{
    public interface ICustomerService
    {
        Customer NewCustomer(string firstName, string lastName, string address); // we are just getting a instance of a customer, not saveing
        Customer CreateCustomer(Customer cust); // saves the previously created instance
        Customer FindCustomerById(int id);
        List<Customer> GetAllCustomers();
        List<Customer> GetAllByFirstName(string name);
        Customer UpdateCustomer(Customer customerUpdate);
        Customer DeleteCustomer(int id);
    }
}
