using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_week2
{
    internal class Program
    {

        static void getters_setters()
        {
            Movies movies1 = new Movies("Titanic", "Jim", "PG-13");
            Movies movies2 = new Movies("Unreleased", "Evans", "PG");

            Console.WriteLine(movies1.Rating);

        }

        static void StaticAtrribute()
        {
            Songs holiday = new Songs("holiday", "green day", 2);
            Songs kashmir = new Songs("kashmir", "led zeppelin", 3);

            Console.WriteLine(Songs.songCount);

        }

        static void static_methods_and_classes()
        {
            Console.WriteLine(Math.Sqrt(144));

            UseFullTools.sayHi("Evans");


        }

        static void inheritance()
        {
            Chef chef = new Chef();
            chef.MakeChicken();

            ItalianChef chef1 = new ItalianChef();
            chef1.MakeChicken();
            chef1.MakePasta();
            chef1.MakeSpeacialDish();
        }
        static void Main(string[] args)
        {

            getters_setters();
            Console.WriteLine();
            Console.WriteLine();

            StaticAtrribute();
            Console.WriteLine();
            Console.WriteLine();

            static_methods_and_classes();
            Console.WriteLine();
            Console.WriteLine();

            inheritance();
            Console.WriteLine();
            Console.WriteLine();


            Corsa car2 = new Corsa();
            Console.WriteLine(car2.wheels);

            Console.ReadKey();
        }

       abstract class Vehicle
        {
            public int wheels = 4;
        }

        class Corsa : Vehicle {
            public int spareWheel = 1;
        }
    }
}
