using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class CustomException:Exception
    {
        public string message{ get; set; }

        public CustomException()
        {
            message = "Invalid Exception ";
        }
        public CustomException(string message)
        { 
        this.message = message;
        }
    }
}
