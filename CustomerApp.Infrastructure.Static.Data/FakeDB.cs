using CustomerApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerApp.Infrastructure.Static.Data
{
    public static class FakeDB
    {
        public static int id = 1;
        public static readonly List<Customer> Customers = new List<Customer>();
    }
}
