

namespace ServiceLayer.Services.Interfaces
{
    public interface IAccount
    {
        bool CheckRole(int roleId);
        string Login(string email, string password,int roleId);
    }
}
