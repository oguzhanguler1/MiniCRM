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



        public void Delete(int id)
        {
            using (var context = new AppDbContext())
            {
                var customer = context.Customers.FirstOrDefault(c => c.Id == id);

                if (customer != null)
                {
                    context.Customers.Remove(customer);
                    context.SaveChanges();
                }
            }
        }








    }
}
