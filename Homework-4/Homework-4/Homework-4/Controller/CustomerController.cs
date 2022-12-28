using DomainLayer.Models;
using ServiceLayer.Services;

namespace Homework_4.Controller
{
    internal class CustomerController
    {
        private readonly CustomerService _service;
        public CustomerController()=> _service = new CustomerService();
        public void GetAvgCustomersAge()=>Console.WriteLine($"Butun ishcilerin ortalama yashi: {_service.GetAvgCustomersAge()}");
        public void GetCustomerCount() => Console.WriteLine($"Yashi 25-30 araliginda olan ishcilerin sayi: {_service.GetCustomerCount()}");
        public void GetCustomerDataByFiltered()
        {
            int start = 22;
            int end = 30;
            Customer[] result = _service.GetCustomerDataByFiltered(start, end);
            foreach (Customer customer in result)
            {
                if (customer !=null)
                {
                    Console.WriteLine($"Filterlenmish ishcilerin melumatlari: Id:{customer.Id} Ad:{customer.Name}" +
                    $" Soyad:{customer.Surname} Yaw:{customer.Age} Posiziya:{customer.Position}");
                }
                
            }
        }
    }
}
