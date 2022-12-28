
using Service.Helpers.Constants;
using Service.Helpers.Enums;
using ServiceLayer.Helpers.Constants;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services
{
    public class Account : IAccount
    {
        public bool CheckRole(int roleId)
        {
            if (roleId == 1)
                return true;
            return false;
        }
        public string Login(string email, string password,int roleId)
        {
            if (email==AccountDatas.Email && password==AccountDatas.Password)
            {
                if (CheckRole(roleId))
                {
                    return Messages.SuccessMsg;
                }
                return Messages.ErrorMsg;
            }
            return Messages.NotFound;
        }
    }
}
