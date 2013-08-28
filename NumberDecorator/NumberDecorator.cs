using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberDecoratorLib
{
    //An interface describing a mapping from an integer to a string. The implementor can choose
    //to return a string to represent an integer based on any rule desired.
    public interface INumberMapper
    {
        string getStringRepresentationForNumber(int number);
    }

    //Class with static methods that produce a collection of output strings based on some input range of numbers
    public class NumberDecorator
    {
        //Given a range of integers from [start, end], returns a list of strings with customized
        //representations of each number in the range. 
        //The mapper parameter in an object implementing the INumberMapper interface
        //Note that any of the list's entries may be null
        //
        //Exceptions thrown:
        //ArgumentException if mapper is invalid
        //ArgumentException if the range is invalid
        public static List<string> getNumberedList(int start, int end, INumberMapper mapper)
        {
            //Validate input
            if (mapper == null)
                throw new ArgumentException("No Number Mapper provided to NumberDecorator.getNumberedList");

            if (end < start)
                throw new ArgumentException("end must be greater than or equal to start");

            List<string> list = new List<string>();
            for (int i = start; i <= end; i++)
            {
                //Get the appropriate string representation of this number
                String representation = mapper.getStringRepresentationForNumber(i);

                //representation may be null. That's up to the INumberMapper implementor whether this is valid or not.

                //Add it to the list
                list.Add(representation);
            }

            return list;
        }
    }
}
