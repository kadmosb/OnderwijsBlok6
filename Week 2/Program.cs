using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnderwijsBlok6.Week2;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                ctx.Students.Add(new Student() { StudentName = "Karel J. van der Lelij", DateOfBirth = new DateTime(1968, 10, 3) });
                ctx.Students.Add(new Student() { StudentName = "Sarah van der Lelij", DateOfBirth = new DateTime(1998, 9, 16) });
                ctx.Students.OrderByDescending(s => s.DateOfBirth);
                ctx.SaveChanges();

                var students = ctx.Students.ToList().Select(s => { Console.Write("Hello "); return s; }); //.ToList ();

                foreach (Student student in students)
                {
                    Console.WriteLine (student.StudentName);
                }

                Console.ReadKey();
            }
        }
    }
}
