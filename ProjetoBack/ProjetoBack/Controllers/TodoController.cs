using Microsoft.AspNetCore.Mvc;
using ProjetoBack.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjetoBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private static List<Todo> _todoList = new List<Todo>();
        // GET: api/<TodoController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_todoList);
        }

        // GET api/<TodoController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Todo _todo =  _todoList.FirstOrDefault(x => x.Id == id);

            if (_todo == null) 
                return NotFound();

            return Ok(_todo);
        }

        // POST api/<TodoController>
        [HttpPost]
        public IActionResult Post([FromBody] Todo todo)
        {

            _todoList.Add(todo);
            return Created();
        }

        // PUT api/<TodoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Todo todoNewData)
        {
            var _todo = _todoList.FirstOrDefault(x => x.Id == id);

            if (_todo == null)
                return NotFound();

            _todoList.Remove(_todo);
            _todoList.Add(todoNewData);

            return Ok(_todo);
        }

        // DELETE api/<TodoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var _todo = _todoList.FirstOrDefault(x => x.Id == id);

            if (_todo == null)
                return NotFound();

            _todoList.Remove(_todo);

            return Ok(_todo);

        }
    }
}
