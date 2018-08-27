using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            LogFactory log = null;

            Console.WriteLine("Press l for Log4net and n for nLog");

            var input = Console.ReadLine();

            switch (input)
            {
                case ("l"):
                    log = new Log4NetFactory("Log4net");
                    break;
                case ("n"):
                    log = new nLogFactory("nLog");
                    break;
                default:
                    Console.WriteLine();
                    break;
            } 

            LogProduct logProduct = log.GetLog();
            Console.WriteLine("You created a {0} log program", logProduct.LogType);
            Console.ReadLine();
        }
    }
}
