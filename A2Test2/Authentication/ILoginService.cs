using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Test2.Authentication
{
    public interface ILoginService
    {
        Task Login(string token);
        Task Logout();
    }
}
