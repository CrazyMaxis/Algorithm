using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Model
{
    public class Question
    {
        [Key]
        public int ID_QUESTION { get; set; }
        public int ID_USER { get; set; }
        public string QUESTION { get; set; }
    }
}
