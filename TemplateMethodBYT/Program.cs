using System;
using TemplateMethodBYT.Models;

namespace TemplateMethodBYT
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.WriteLine("type in operation sign");
            input = Console.ReadLine();

            Client.ClientCode(new ConcreteCalculator(input));
        }
    }
}
