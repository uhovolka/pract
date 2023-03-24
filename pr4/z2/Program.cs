using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            pacage package_1 = new pacage("легкая посылка", 4);
            pacage package_2 = new pacage("тяжелая посылка", 10);
            service sendingService = new service();
            sendingService.send(package_1);
            sendingService.send(package_2);
            Console.ReadKey(true);
        }
        class pacage
        {
            public int heft
            {
                get;
                private set;
            }
            public string description
            {
                get;
                private set;
            }
            public pacage(string description_val, int heft_val)
            {
                description = description_val;
                heft = heft_val;
            }
        }
        class service
        {
            private static int maxheft;
            private const int max = 12;
            public void send(pacage package)
            {
                maxheft += package.heft;
                if (maxheft >= max)
                {
                    Console.WriteLine("вес посылки слишком большой!");
                }
                else
                {
                    Console.WriteLine("{0} весом {1} фунтов успешно отправлена.", package.description, package.heft);
                }
            }
        }
    }
}
