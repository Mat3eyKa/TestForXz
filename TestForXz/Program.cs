using System;
using System.Collections.Generic;
using TestForXz.Models;

namespace TestForXz
{
    internal class Program
    {
        static void Main()=>
            Print(DataWorker.Seeeder());

        private static void Print(IEnumerable<Person> people)
        {
            foreach (var item in people)
                Console.WriteLine($"{item.Name}-{item.Amount}р.");
        }
    }
}
