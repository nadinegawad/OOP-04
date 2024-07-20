using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_AS_04
{
    internal interface IAuthenticationService
    {
        public void AuthenticateUser();
        public void AuthorizeUser();

    }
}
