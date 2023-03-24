using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    interface IHello
    {
        void SayHello();
    }
    class Russian : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Привет");
        }
    }
    class English : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hi");
        }
    }
    class Deutsch : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hallo");
        }
    }
    class Korean : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("안녕");
        }
    }
    class Japan : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("こんにちは");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IHello> greetings = new List<IHello>();
            greetings.Add(new Russian());
            greetings.Add(new English());
            greetings.Add(new Deutsch());
            greetings.Add(new Korean());
            greetings.Add(new Japan());
            foreach (IHello hello in greetings)
            {
                hello.SayHello();
            }
            Console.ReadKey(true);
        }
    }
}
