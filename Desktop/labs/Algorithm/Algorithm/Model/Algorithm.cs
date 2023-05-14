using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Model
{
    public class Algorithm
    {
        [Key]
        public int ID_ALGORITHM { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public int LEVEL { get; set; }
        public string IMAGE_SOURCE { get; set; }
        public string PATH_TO_PRESENTATION { get; set; }
    }
}
