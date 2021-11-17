using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_Bdjobs.Models
{
    public class Jobs
    {
        public int ID { get; set; }
        public string  jobType { get; set; }
        public string description { get; set; }
        public string  vacancy { get; set; }
        public string  jobHolder { get; set; }
    }
}
