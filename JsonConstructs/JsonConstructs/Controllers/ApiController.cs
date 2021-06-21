using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace JsonConstructs.Controllers
{
    [ApiController]
    [Route("v1/landing")]
    public class ApiController : Controller
    {
        [HttpGet]
        [Route("{id}")]
        public string GetJson(string id)
        {
            return new WebClient().DownloadString("https://raw.githubusercontent.com/PerspectifyTechnologies/LarcelLandingDatastore/main/Constructs/" + id + ".json");
        }
    }
}
