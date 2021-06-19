using JsonConstructs.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonConstructs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : Controller
    {
        private static readonly string[] SomeText = new[]
        {
            "some", "thing", "cool", "i am", "working", "on", "but", "i have", "little to no", "idea","what","I am","Doing..!!"
        }; 

        [HttpGet]
        public string First()
        {
            return "DEMO";
        }
        
        [HttpGet("faq")]

        public IEnumerable<FaqModel> GetFaq()
        {
            var rng = new Random(); 
            return Enumerable.Range(1, 5).Select(index => new FaqModel
            {
                ID = index,
                Questions = SomeText[rng.Next(SomeText.Length)],
                Answers = SomeText[rng.Next(SomeText.Length)],
                Meta = new MetaModel{
                    Title = SomeText[rng.Next(SomeText.Length)],
                    Description = SomeText[rng.Next(SomeText.Length)],
                }

            })
            .ToArray();

        }
    }
}
