using System;

namespace UserInputBriannaPereira
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, this is Brianna Pereira! Let me know how you are doing, just type your answer below and pres ENTER:");
            string name = Console.ReadLine();
            Console.WriteLine("You typed: " + name);
            Console.ReadKey();

        }
    }
}
