using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;

IAccount account = new Account();
Console.WriteLine("Emailinizi daxil edin:");
string email = Console.ReadLine();

Console.WriteLine("Sifrenizi daxil edin:");
string password = Console.ReadLine();

Console.WriteLine("Hansi roleda oldugunuzu secin: 1-SuperAdmin, 2-Admin, 3-Member");
string roleIdStr= Console.ReadLine();
int roleId;
bool IsParseRoleId= int.TryParse(roleIdStr, out roleId);

if (!IsParseRoleId || roleId<1 || roleId>3)
{
    Console.WriteLine("Duzgun reqem daxil edin");
     roleIdStr= Console.ReadLine();
}

var result = account.Login(email,password,roleId);
Console.WriteLine(result);