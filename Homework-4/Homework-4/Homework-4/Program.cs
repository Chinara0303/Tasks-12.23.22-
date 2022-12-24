
using DomainLayer.Models;
using ServiceLayer.Services;

static Customer[] GetCustomers()
{
    Customer customer1 = new Customer
    {
        Id= 1,
        Name="Chinara",
        Surname="Ibadova",
        Position="Developer",
        Age=22
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
    Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4};
    return customers;
}


CustomerService customer = new CustomerService();
var result1 =customer.GetCustomerCount(GetCustomers());
Console.WriteLine($"Yashi 25-30 araliginda olan ishcilerin sayi: {result1}");

var result2= customer.GetAvgCustomersAge(GetCustomers());
Console.WriteLine($"Butun ishcilerin ortalama yashi: {result2}");