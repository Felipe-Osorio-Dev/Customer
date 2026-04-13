using CustomerAPP.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAPP.Views.Register
{
    public class CustomerEventArgs : EventArgs
    {
        public CustomerRegisterRequest _request { get; }

        public CustomerEventArgs(CustomerRegisterRequest request)
        {
            _request = request;
        }
    }
}
