using MyLoginApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyLoginApp.Services
{
    public class LoginService : ILoginRepository
    {
        public Task<UserInfo> Login(string username, string password)
        {
            try
            {
                if (Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
                {
                    var userInfo = new UserInfo();
                    var client = new HttpClient();

                    string url = "http://192.168.1.107:8099/api/UserInfoes/LoginUser/" + username + "/" + password;

                }
            }
            catch { }
            throw new NotImplementedException();
        }
    }
}
