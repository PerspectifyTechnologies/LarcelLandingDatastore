﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonConstructs.Models
{
    public class FaqModel
    {
        public string ID { get; set; }
        public string Questions { get; set; }
        public string Answers { get; set; }
        public MetaModel Meta { get; set; }
    }
}
