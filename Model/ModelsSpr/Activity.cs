using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelsSpr
{
    public class Activity
    {
        public int id { get; set; }
        public string ActivityName { get; set; }    
        public string objects { get; set; }
        public int ZoomNumber { get; set; }
        public string ActivityType { get; set; }
        public string description { get; set; }
    }
}
