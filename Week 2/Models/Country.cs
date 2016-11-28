using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.Models;

namespace Week3.Models
{
    public class Country
    {
        public Country ()
        {
        }

        public int CountryID { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }

        public virtual List<Student> Studenten { get; set; }
    }
}
