using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.Models;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                ctx.Studenten.Add(new Student() {
                    StudentName = "Karel J.",
                    StudentKey = 20,
                    Country = new Country () { CountryCode = "NL", CountryName = "Nederland"}
                });

                ctx.SaveChanges();

                foreach (Student s in ctx.Studenten)
                {
                    Console.WriteLine($"Naam van de studen is {s.StudentName}, ID is {s.StudentKey} en woont in {s.Country.CountryName}");

/*
 *                    if (s.Country == null)
                    {
                        Console.WriteLine("Student is vluchteling");
                    }
                    else
                    {
                        Console.WriteLine($"Student woont in {s.Country.CountryName}");
                    }
 */
                }
                Console.ReadKey();
            }
        }
    }
}
