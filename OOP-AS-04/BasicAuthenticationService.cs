using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_AS_04
{
    internal class BasicAuthenticationService : IAuthenticationService , IComparable
    {

        public string Name { get; set; }
        public string password { get; set; }
        public void AuthenticateUser()
        {
            throw new NotImplementedException();
        }

        public void AuthorizeUser()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }
}
