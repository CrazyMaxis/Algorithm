using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Model
{
    public class User_Activity
    {
        [Key]
        public int ID_USER_ACTIVITY { get; set; }
        public int ID_USER { get; set; } 
        public int ID_ALGORITHM { get; set; } 
        public DateTime ACTIVITY_DATE { get; set; } 
    }
}
