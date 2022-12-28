using ServiceLayer.Services;

namespace Homework_4.Controller
{
    internal class CustomerController
    {
        private readonly CustomerService _service;
        public CustomerController()=> _service = new CustomerService();
        public void GetAvgCustomersAge()=>Console.WriteLine($"Butun ishcilerin ortalama yashi: {_service.GetAvgCustomersAge()}");
        public void GetCustomerCount() => Console.WriteLine($"Yashi 25-30 araliginda olan ishcilerin sayi: {_service.GetCustomerCount()}");
    }
}
