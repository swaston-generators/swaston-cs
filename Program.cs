using System;

namespace SwastonGenerator
{
    static class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(SwastonGenerator.FromString(input));
        }
    }
}
