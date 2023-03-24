using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.avto = "Koenigsegg Agera RS";
            car1.maxSpeed = 300;
            car1.Print();

            Car car2 = new Car();
            car2.avto = "mazda rx-7";
            car2.maxSpeed = 400;
            car2.Print();

            Car car3 = new Car();
            car3.avto = "Aston Martin Vanquish";
            car3.maxSpeed = 200;
            car3.Print();

            Car car4 = new Car();
            car4.avto = "Audi R8";
            car4.maxSpeed = 100;
            car4.Print();


            if (car2.maxSpeed > car1.maxSpeed)
            {
                Console.WriteLine($"Победитель - mazda rx-7");
            }

            if (car1.maxSpeed > car4.maxSpeed)
            {
                Console.WriteLine($"2 место - Koenigsegg Agera RS");
            }

            if (car4.maxSpeed > car3.maxSpeed)
            {
                Console.WriteLine($"3 место - Audi R8");
            }
        }
             class Car
        {
            public string avto;
            public int maxSpeed;
            public void Print()
            {
                Console.WriteLine($"Гоночный автомобиль: {avto}");
                Console.WriteLine($"Его максимальная скорость: {maxSpeed}");
            }

        }
    }
           
    }


