using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Week2.Models
{
    public class Country
    {
        public Country ()
        {
            Students = new List<Student>();
        }

        public int CountryID { get; set; }

        [StringLength(2)]
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public int NOInhabitants { get; set; }
        public string Capital { get; set; }
        public virtual IList<Student> Students { get; set; }
    }
}
