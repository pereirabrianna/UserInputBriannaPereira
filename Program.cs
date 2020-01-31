using System;

namespace UserInputBriannaPereira
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name and Press ENTER ");
            string name = Console.ReadLine();
            Console.WriteLine("Hi, this is " + name);
            Console.ReadKey();

        }
    }
}
