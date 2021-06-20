using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonConstructs.Models
{
    public class FaqCollection
    {
        private List<FaqModel> faq;
        public List<FaqModel> Faq { get => faq; set => faq = value; }
    }
}
