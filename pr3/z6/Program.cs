using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z6
{
    class Program
    {
        static void Main(string[] args)
        {
            MyRandomList numbers = new MyRandomList();
            for (int i = 0; i < 11; i++)
            {
                numbers.AddNumber();
            }
            Console.WriteLine(numbers.varian);
            Console.WriteLine(numbers.dev);
            Console.WriteLine(numbers.median);
            Console.ReadKey(true);
        }

        class MyRandomList
        {
            private List<int> numbersList = new List<int>();
            Random rand = new Random();
            private int n
            {
                set
                {
                    SetLength(value);
                }
            }
            public double aver
            {
                get
                {
                    return avercalc();
                }
            }
            public double varian
            {
                get
                {
                    return variancalc();
                }
            }
            public double dev
            {
                get
                {
                    return nachdevcalc();
                }
            }
            public double median
            {
                get
                {
                    return medcalc();
                }
            }
            private void SetLength(int n)
            {
                n = numbersList.Count;
            }
            public void AddNumber()
            {
                numbersList.Add(rand.Next(101));
            }
            public void RemoveNumber(int number)
            {
                numbersList.Remove(number);
            }
            private double avercalc()
            {
                int sum = 0;
                foreach (int number in numbersList)
                {
                    sum += number;
                }
                return sum / numbersList.Count;
            }
            private double variancalc()
            {
                double sum = 0;
                foreach (int number in numbersList)
                {
                    sum += Math.Pow((number - aver), 2);
                }
                return Math.Round(sum / numbersList.Count, 2);
            }
            private double nachdevcalc()
            {
                variancalc();
                return Math.Round(Math.Sqrt(varian), 2);
            }
            private double medcalc()
            {
                numbersList.Sort();
                if (numbersList.Count % 2 == 0)
                {
                    return (numbersList[numbersList.Count / 2] + numbersList[numbersList.Count / 2 - 1]) / 2;
                }
                else
                {
                    double middle = numbersList.Count / 2;
                    middle = Math.Ceiling(middle);
                    return numbersList[Convert.ToInt32(middle)];
                }
            }
        }
    }
}
