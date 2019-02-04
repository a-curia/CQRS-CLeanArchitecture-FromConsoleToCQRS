using CustomerApp.Core.Entity;
using System;
using System.Collections.Generic;
using CustomerApp.Core.ApplicationService;
using CustomerApp.Core.DomainService;
using CustomerApp.Infrastructure.Static.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using CustomerApp.Core.ApplicationService.Services;

namespace ConsoleApp2017
{
    //CustomerRepository Interface
    //Create Data
    //Read Data
    //Update Data
    //Delete Data

    //-- UI --
    //Console.WriteLine
    //Console.ReadLine

    //-- Infrastructure --
    //EF - Static List - Text File

    //-- Test --
    //Unit test for Core

    //-- CORE --
    //Customer - Entity - Core.Entity
    //Domain Service - Repository / UOW - Core; should contain services for working with the Infrastructure
    //Application Service - Service - Core; should contain services for working with the UI

    class Program
    {

        static void Main(string[] args)
        {
            //var printer = new Printer();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<ICustomerRepository, CustomerRepository>();
            serviceCollection.AddScoped<ICustomerService, CustomerService>();
            serviceCollection.AddScoped<IPrinter, Printer>();

            // then build provider
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var printer = serviceProvider.GetRequiredService<IPrinter>();
            printer.StartUI();
        }
    }
}
