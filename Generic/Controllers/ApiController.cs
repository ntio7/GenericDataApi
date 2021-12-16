using Microsoft.AspNetCore.Mvc;
using Generic.BL;

namespace Generic.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly IGenericRepository? Repository;

        public ApiController(IGenericRepository Repository)
        {
            this.Repository = Repository;
        }

        // GET: api/<ApiController>
        [HttpGet]
        public ActionResult<string> Get()
        {

            return Repository.GetItems();

           // return new string[] { "value1", "value2" };
        }

        // GET api/<ApiController>/5
        [HttpGet("{id}")]
        [ApiVersion("2.0")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        public IActionResult Get(int id)
        {
            return Ok("value");
        }

        // POST api/<ApiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
