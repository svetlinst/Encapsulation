using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < numberOfLines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0],
                    cmdArgs[1],
                    int.Parse(cmdArgs[2]),
                    decimal.Parse(cmdArgs[3]));

                persons.Add(person);
            }

            var bonus = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(bonus));
            persons.ForEach(p => Console.WriteLine(p.ToString()));


            //persons.OrderBy(p=>p.FirstName)
            //    .ThenBy(p=>p.Age)
            //    .ToList()
            //    .ForEach(p=>Console.WriteLine(p));

        }
    }
}
