using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Model
{
    public class Achievement
    {
        [Key]
        public int ID_ACHIEVEMENT { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
    }
}
