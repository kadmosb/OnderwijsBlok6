using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Models
{
    public class Student
    {
        public Student ()
        {
        }

        [Key]
        public int StudentKey { get; set; }
        public string StudentName { get; set; }

        public virtual Country Country { get; set; }
    }
}
