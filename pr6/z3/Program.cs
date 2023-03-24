using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    class Human
    {
        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public char Gender
        {
            get;
            set;
        }
        public Human(string name, int age, char gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
    }
    class Worker : Human
    {
        public string Position
        {
            get;
            set;
        }
        public Worker(string name, int age, char gender, string position) : base(name, age, gender)
        {

            Position = position;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Human chel1 = new Human("Алексей Квашонкин", 31, 'М');
            Console.WriteLine(chel1.Name);
            Worker chel2 = new Worker("Ариана Лолаева", 26, 'Ж', "комик");
            Console.WriteLine(chel2.Position);
            Console.ReadKey(true);
        }
    }
}
