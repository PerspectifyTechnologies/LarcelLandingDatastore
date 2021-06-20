using JsonConstructs.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Net;
using System.Threading.Tasks;

namespace JsonConstructs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : Controller
    {
        [HttpGet]
        [Route("{id}")]
        public string GetJson(string id)
        {
            WebClient client = new WebClient();
            string path = @"https://raw.githubusercontent.com/PerspectifyTechnologies/LarcelLandingDatastore/main/Constructs/" + id + ".json";
            try
            {
                var rawJSON = client.DownloadString(path);
                if (id == "faq")
                    return JsonConvert.SerializeObject(JsonConvert.DeserializeObject<FaqCollection>(rawJSON));
                else if (id == "heading")
                    return JsonConvert.SerializeObject(JsonConvert.DeserializeObject<HeadingCollection>(rawJSON));
                else if (id == "steps")
                    return JsonConvert.SerializeObject(JsonConvert.DeserializeObject<StepsCollection>(rawJSON));
                else if (id == "category")
                    return JsonConvert.SerializeObject(JsonConvert.DeserializeObject<CategoryCollection>(rawJSON));
            }
            catch (Exception e)
            {
                return e.Message;
            }
                return "bad request";
        }
    }
}
