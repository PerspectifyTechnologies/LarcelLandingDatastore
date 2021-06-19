using JsonConstructs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonConstructs.Models
{
    public class StepsModel
    {
        public int Index { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public MetaModel Meta { get; set; }
    }
}
