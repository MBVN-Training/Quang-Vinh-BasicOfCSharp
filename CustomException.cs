using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibrary
{
    public class CustomException
    {
        public class OutOfOptionException : Exception
        {
            const string ErrorMessage = "Out of option. Please choose in sequence options";
            public OutOfOptionException() : base(ErrorMessage)
            {
            }

        }
    }
}
