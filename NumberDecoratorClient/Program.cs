using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NumberDecoratorLib;

namespace NumberDecoratorClient
{
    class Program
    {
        //Exercises the NumberDecorator using both the built-in FizzBuzzMapper, and a
        //custom number mapper (SquareMapper) developed by the client.

        static void Main(string[] args)
        {
            runSquare();

            Console.WriteLine();
            
            runFizzBuzz();

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }

        static void runSquare()
        {
            Console.WriteLine("Results of using SquareMapper from 0 to 100:");

            var squareMapper = new SquareMapper();
            List<string> list = NumberDecorator.getNumberedList(0, 100, squareMapper);

            foreach (String s in list)
            {
                Console.WriteLine(s);
            }
        }

        static void runFizzBuzz()
        {
            Console.WriteLine("Results of using FizzBuzzMapper from 1 to 100:");
            List<string> list = NumberDecorator.getNumberedList(1, 100, new FizzBuzzMapper());

            foreach (String s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
