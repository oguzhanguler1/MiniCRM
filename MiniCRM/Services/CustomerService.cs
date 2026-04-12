using MiniCRM.Data;
using MiniCRM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniCRM.Services
{
    public class CustomerService
    {
        public List<Customer> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.Customers
                              .OrderBy(c => c.Id)
                              .ToList();
            }
        }



        public void Add(Customer customer)
        {
            using (var context = new AppDbContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }



    }
}
