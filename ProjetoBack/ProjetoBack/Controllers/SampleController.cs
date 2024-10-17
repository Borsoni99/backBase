using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SampleController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetSample()
        {
            List<String> list = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                list.Add("Retorno " + i.ToString());
            }
            return Ok(list);
        }
    }
}
