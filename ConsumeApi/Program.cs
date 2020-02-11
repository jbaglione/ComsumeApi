using JsonRequest.Methods;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeApi
{
    class Program
    {
        static void Main(string[] args)
        {
            string server = ConfigurationManager.AppSettings["server"];
            SendMethods sm = new SendMethods();
            sm.ConfirmOrder(new Order());
        }
    }
}
