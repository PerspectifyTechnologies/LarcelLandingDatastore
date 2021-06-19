using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonConstructs.Models
{
    public class CategoryModel
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public MetaModel Meta { get; set; }
    }
}
