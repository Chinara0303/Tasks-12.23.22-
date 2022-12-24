using DomainLayer.Models;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CustomerService : ICustomerService
    {
        public int GetAvgCustomersAge(Customer[] customers)
        {
            int count = 0;
            int sum = 0;
            foreach (Customer customer in customers)
            {
                count++;
                sum += customer.Age;
            }
            int average = sum / count;
            return average;
        }

        public int GetCustomerCount(Customer[] customers)
        {
            int count = 0;
            foreach (Customer customer in customers)
            {
                if (customer.Age>25 && customer.Age<30)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
