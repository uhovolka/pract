using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc orc1 = new Orc();
            Console.WriteLine(Orc.total_gold);
            Orc orc2 = new Orc();
            Orc orc3 = new Orc();
            Console.WriteLine(Orc.total_gold);
            Orc orc4 = new Orc();
            Orc orc5 = new Orc();
            Orc orc6 = new Orc();
            Console.WriteLine(orc6.nogold);
            Console.ReadKey(true);
        }

        class Orc
        {
            private static int count;
            public static int total_gold
            {
                get; private set;
            }
            public int nogold
            {
                get; private set;
            }
            public Orc()
            {
                count++;
                total_gold += 2;
                if (count > 5)
                {
                    nogold += 2;
                }
            }
        }
    }
}
