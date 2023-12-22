using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsAPIController : ControllerBase
    {
        public List<string> Fruits = new List<string>()
        {
            "Apple",
            "Mango",
            "Banana",
            "Grapes"
        };
        [HttpGet]
        public List<string> getFruits()
        {
            return Fruits;
        }
        [HttpGet("{id}")]
        public string GetFruitsByIndex(int id)
        {
            return Fruits.ElementAt(id);
        }
    }
}
