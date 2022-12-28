using DomainLayer.Models;
using ServiceLayer.Services.Interfaces;


namespace ServiceLayer.Services
{
    public class CustomerService : ICustomerService
    {
        public int GetAvgCustomersAge()
        {
            int sum = 0;
            foreach (Customer customer in GetCustomers())
            {
                sum += customer.Age;
            }
            return sum / GetCustomers().Length;
        }

        public int GetCustomerCount()
        {
            int count = 0;
            foreach (Customer customer in GetCustomers())
            {
                if (customer.Age > 25 && customer.Age < 30)
                {
                    count++;
                }
            }
            return count;
        }

        public Customer[] GetCustomerDataByFiltered(int startAge, int endAge)
        {
            Customer[] customers= GetCustomers();
            Customer[] datas = new Customer[customers.Length];
            int count = 0;
            foreach (Customer customer in GetCustomers())
            {
                if (customer.Age > startAge && customer.Age < endAge)
                {
                    datas[count]=customer;
                    count++;
                }
                //if (customer.Age>startAge && customer.Age<endAge)
                //{
                //    datas += $"{customer.Id} {customer.Name} {customer.Surname} {customer.Position} {customer.Age}  ";
                //}
            }
            return datas;
        }

        private Customer[] GetCustomers()
        {
            Customer customer1 = new Customer
            {
                Id = 1,
                Name = "Chinara",
                Surname = "Ibadova",
                Position = "Developer",
                Age = 22
            };

            Customer customer2 = new Customer
            {
                Id = 2,
                Name = "Konul",
                Surname = "Ibrahimova",
                Position = "Developer",
                Age = 26
            };

            Customer customer3 = new Customer
            {
                Id = 3,
                Name = "Roya",
                Surname = "Meherremova",
                Position = "Developer",
                Age = 26
            };

            Customer customer4 = new Customer
            {
                Id = 4,
                Name = "Gunel",
                Surname = "Novruzova",
                Position = "Developer",
                Age = 23
            };
            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };
            return customers;
        }
    }
}
