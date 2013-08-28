using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NumberDecoratorLib;

namespace NumberDecoratorClient
{
    //A mapper that returns the string "Square" if the number is a perfect square, else the
    //number unchanged.
    public class SquareMapper : INumberMapper
    {
        //Determine if an integer is a square by checking if the square root is an
        //integer. It's an integer if the ceiling and floor are the same.
        protected bool isSquare(int number)
        {
            //Obviously no negative number can be a square
            if (number < 0)
                return false;

            double sqrt = Math.Sqrt((double)number);

            //Just in case, check for NaN
            if (Double.IsNaN(sqrt))
                return false;

            //If the ceiling and floor are the same value, then it's an integer, and therefore
            //the number we are checking is a square
            return Math.Ceiling(sqrt) == Math.Floor(sqrt);
        }


        public string getStringRepresentationForNumber(int number)
        {
            if (isSquare(number))
                return "Square";
            else return number.ToString();
        }

    }
}
