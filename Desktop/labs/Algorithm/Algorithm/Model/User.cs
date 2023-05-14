using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Model
{
    public class User
    {
        [Key]
        public int ID_USER { get; set; }
        public string LOGIN { get; set; }
        public string EMAIL { get; set; }
        public string PASSWORD { get; set; }
        public int LEVEL { get; set; }
        public string IMAGE_SOURCE { get; set; }
    }
}
