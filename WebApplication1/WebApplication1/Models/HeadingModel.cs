using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonConstructs.Models
{ 
    public class HeadingModel
    {
        public int PanelID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public MetaModel Meta { get; set; }
    }
}
