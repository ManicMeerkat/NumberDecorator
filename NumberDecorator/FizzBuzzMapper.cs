using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//This provides a sample implementation of INumberMapper as part of the NumberDecoratorLib library.

namespace NumberDecoratorLib
{
    //A Number Mapper that returns:
    //"fizz" if the number is divisible by 3
    //"buzz" if the number is divisible by 5
    //"fizzbuzz" if divisible by both
    //otherwise, the input number as a string unmodified
    public class FizzBuzzMapper : INumberMapper
    {
        public string getStringRepresentationForNumber(int number)
        {
            //Initialize the stringas the number itself
            string representation = number.ToString();

            //If divisible by 3
            if ((number % 3) == 0)
            {
                //Also check if divisible by both
                if ((number % 5) == 0)
                {
                    representation = "fizzbuzz";
                }
                else
                {
                    representation = "fizz";
                }
            }
            //Maybe divisible by 5?
            else if ((number % 5) == 0)
            {
                representation = "buzz";
            }

            return representation;
        }
    }
}
