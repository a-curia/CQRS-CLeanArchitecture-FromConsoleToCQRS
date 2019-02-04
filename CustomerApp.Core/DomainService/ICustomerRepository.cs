using CustomerApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerApp.Core.DomainService
{
    public interface ICustomerRepository
    {
        //CustomerRepository
        //Create Data
        Customer Create(Customer customer); // no ID when enter, but ID when exit
        //Read Data
        Customer ReadById(int id);
        IEnumerable<Customer> ReadAll();
        //Update Data
        Customer Update(Customer customerUpdate);
        //Delete Data
        Customer Delete(int id);

    }
}
