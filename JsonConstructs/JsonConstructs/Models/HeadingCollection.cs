using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonConstructs.Models
{
    public class HeadingCollection
    {
        private List<HeadingModel> heading;
        public List<HeadingModel> Heading { get => heading; set => heading = value; }
    }
}
