using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonConstructs.Models
{
    public class CategoryCollection
    {
        private List<CategoryModel> category;
        public List<CategoryModel> Category { get => category; set => category = value; }
    }
}
