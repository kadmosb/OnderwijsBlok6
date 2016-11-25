using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Week2.Models
{
    public class Student
    {
        public Student ()
        {
        }

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public int fkCountryID { get; set; }

        [ForeignKey("fkCountryID")]
        public virtual Country Country { get; set; }
    }
}
