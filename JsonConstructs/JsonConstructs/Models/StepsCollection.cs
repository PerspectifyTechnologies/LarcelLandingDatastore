using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonConstructs.Models
{
    public class StepsCollection
    {
        private List<StepsModel> steps;
        public List<StepsModel> Steps { get => steps; set => steps = value; }
    }
}
