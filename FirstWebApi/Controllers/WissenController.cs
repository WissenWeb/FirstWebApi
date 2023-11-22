using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace FirstWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WissenController : ControllerBase
    {

        [HttpGet]
        public int Index()
        {
            return 18;
        }

        [HttpPost]
        public string Post(string deger) {

            string newvalue = "";
            for (int i = deger.Length - 1; i >= 0; i--)
            {
                newvalue += deger[i];
            }
            return newvalue;
           

        }
        
    }
}
