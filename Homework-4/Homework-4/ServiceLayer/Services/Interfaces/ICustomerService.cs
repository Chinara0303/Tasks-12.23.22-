using DomainLayer.Models;

namespace ServiceLayer.Services.Interfaces
{
    public interface ICustomerService
    {
        int GetCustomerCount();
        int GetAvgCustomersAge();
        //string GetCustomerDataByFiltered(int startAge,int endAge);
        Customer[] GetCustomerDataByFiltered(int startAge,int endAge);
    }
}
