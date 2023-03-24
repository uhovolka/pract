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
            Program num = new Program();
            int n;
            for (int i = 1; i >= 0; i = num.N(n) + 1)
            {
                Console.WriteLine($"введите число {i}");
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey(true);
        }

        private int n = 0;
        public int N(int n)
        {
            this.n = 1;
            return n;
        }

        private bool SetNumber(int number)
        {
            if (number == this.n + 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
