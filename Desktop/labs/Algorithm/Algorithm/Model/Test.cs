using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Model
{
    public class Test
    {
        [Key]
        public int ID_TEST { get; set; }
        public string NAME { get; set; }
        public int LEVEL { get; set; }
        public string SOURCE { get; set; }
        public string IMAGE_SOURCE { get; set; }
    }
}
