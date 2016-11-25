using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2.Models;

namespace Week2
{
    class Program
    {
        static void AddCountry (SchoolContext ctx, string countryCode, string countryName)
        {
            if (ctx.Countries.Where (c => c.CountryCode.Equals (countryCode)).Count () == 0)
            {
                int countryID = 0;

                if (ctx.Countries.Count () > 0)
                {
                    countryID = ctx.Countries.Max(c => c.CountryID) + 1;
                }

                ctx.Countries.Add(new Country()
                {
                    CountryID = countryID,
                    CountryCode = countryCode,
                    Name = countryName
                });

                ctx.SaveChanges();
            }
        }

        static Country GetCountry (SchoolContext ctx, string countryCode)
        {
            return ctx.Countries.Where(c => c.CountryCode == countryCode).FirstOrDefault ();
        }

        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                AddCountry(ctx, "NL", "Nederland");
                AddCountry(ctx, "DE", "Deutschland");

                ctx.Students.Add(new Student()
                {
                    StudentName = "Karel J. van der Lelij",
                    DateOfBirth = new DateTime(1968, 10, 3),
                    Country = GetCountry(ctx, "NL")
                });

                ctx.Students.Add(new Student()
                {
                    StudentName = "Sarah van der Lelij",
                    DateOfBirth = new DateTime(1998, 9, 16),
                    Country = GetCountry(ctx, "DE")
                });

                ctx.Students.OrderByDescending(s => s.DateOfBirth);
                ctx.SaveChanges();

                foreach (Student student in ctx.Students)
                {
                    Console.WriteLine ("{0} woont in {1} ({2})", student.StudentName, student.Country.Name, student.Country.CountryCode);
                }

                Console.ReadKey();
            }
        }
    }
}
