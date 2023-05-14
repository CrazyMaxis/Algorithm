using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Model
{
    public class Courses
    {
        [Key]
        public int ID_COURSE { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string IMAGE_SOURCE { get; set; }
        public double PRICE { get; set; }
    }
}
