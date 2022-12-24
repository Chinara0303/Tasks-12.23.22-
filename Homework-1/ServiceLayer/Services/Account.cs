
using Service.Helpers.Constants;
using Service.Helpers.Enums;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services
{
    public class Account : IAccount
    {
        public string Login(string email, string password,int roleId)
        {
            if (email=="test@code.edu.az" && password=="test12345" &&  roleId == 1)
            {
                return Errors.LoginSuccessMsg;
            }
            else if(roleId != 1)
            {
                return Errors.LoginErrorMsg;
            }
            return Errors.LoginMsg;
        }
    }
}
