using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelsSpr
{
    public class activity
    {
        public int id { get; set; }
        public string activity_name { get; set; }    
        public string objects { get; set; }
        public int number_of_zoom { get; set; }
        public string activity_type { get; set; }
        public string description { get; set; }
    }
}
