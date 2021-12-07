using System;
using Cats;

// namespace declaration
namespace Cats
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat Misha = new Cat(2);

            Console.WriteLine($"Misha is {Misha.Age} years old!");
            Misha.Meow();

            Misha.Age = 5;
            Console.WriteLine($"Misha is {Misha.Age} years old!");
            Misha.Meow();

        }


    }
}
