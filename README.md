NumberDecorator
===============
This Visual Studio 2008 solution contains 3 projects:

- NumberDecorator--A C# library that contains:
   1) A class NumberDecorator with a single static method to produce a list of strings based on a range of integers.
   2) An interface INumberMapper that defines how the logic to handle the conversion of an integer to a string should work
   3) A sample class FizzBuzzMapper that implements INumberMapper as a reference

- NumberDecoratorClient--A C# console application that exercises the NumberDecorator library. It also defines a class SquareMapper which demonstrates a custom implementation of the INumberMapper interface.

- NumberDecoratorTester--A set of unit tests that ensure the library entry points behave as expected, using the library's FizzBuzzMapper as a reference.

  