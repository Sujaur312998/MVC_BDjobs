using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web_Bdjobs.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //[DataType(DateType.DateTime)]
        public DateTime Birthday { get; set; }
        public string Discription { get; set; }
        public string Address { get; set; }
        public string cv { get; set; }
    }
}
