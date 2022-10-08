using A2Test2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A2Test2.DTOs;

namespace A2Test2.Repository
{
    public class AccountsRepository : IAccountsRepository
    {
        private readonly IHttpService httpService;
        private readonly string baseURL = "api/auth";

        public AccountsRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }


        public async Task<UserToken> Register(UserInfo userInfo)
        {
            var httpResponse = await httpService.Post<UserInfo, UserToken>($"{baseURL}/create", userInfo);

            if (!httpResponse.Success)
            {
                var body = httpResponse.GetBody().Result;
                return(new UserToken() { ErrorMessage = body });
            }

            return httpResponse.Response;
        }

        public async Task<UserToken> Login(UserInfo userInfo)
        {
            var httpResponse = await httpService.Post<UserInfo, UserToken>($"{baseURL}/login", userInfo);

            if (httpResponse.ResponseStatusCode == 401)
            {
                return new UserToken()
                {
                    Token = "failed"
                };
            }

            return httpResponse.Response;
        }

        public async Task<UserToken> RenewToken()
        {
            var response = await httpService.Get<UserToken>($"{baseURL}/RenewToken");

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }
    }
}
