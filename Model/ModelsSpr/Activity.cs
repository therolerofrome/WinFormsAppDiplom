using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelsSpr
{
    public class Activity
    {
        public int Id { get; set; }
        public string ActivityName { get; set; }    
        public string Objects { get; set; }
        public int NumberOfZoom { get; set; }
        public string ActivityType { get; set; }
        public string Description { get; set; }
    }
}
