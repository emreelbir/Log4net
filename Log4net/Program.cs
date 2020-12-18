using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch =true)]

namespace Log4net
{
    class Program
    {
        private static readonly log4net.ILog log = LogHelper.GetLogger();//(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            log.Error("This is my error massage ! ");

            Console.ReadLine();
        }
    }
}
