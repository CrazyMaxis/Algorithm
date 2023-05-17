using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Model
{
    public class User_Test
    {
        [Key]
        public int ID_USER_TEST { get; set; }
        public int ID_USER { get; set; }
        public int ID_TEST { get; set; }
    }
}
