using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BmiCalculatorApp.models;

namespace BmiCalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] per = new Person[]
            {
                new Person(101, "Riya", 21),
                new Person(201, "Roshani", 21, 1.75f, 55),
                new Person(301, "Mary", 30, 2f, 100)
            };

            // Print information and body type for each person

            foreach (Person person in per)
            {
                Console.WriteLine(person); //calls toString method
                Console.WriteLine(Person.BodyType(person.CalculateBmiScore()));
                Console.WriteLine();

            }

        }

    }
}
