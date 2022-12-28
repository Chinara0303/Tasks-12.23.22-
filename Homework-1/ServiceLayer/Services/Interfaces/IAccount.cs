

namespace ServiceLayer.Services.Interfaces
{
    public interface IAccount
    {
        string Login(string email, string password,int roleId);
    }
}
