using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private static List<Event> events = new List<Event> { new Event { Id = 1, Title = "default" }};

    // GET: api/<EventsController>
    [HttpGet]
        public IEnumerable<Event> Get()
        {
            return events;
        }
        public EventsController()
        {
                
        }

        //// GET api/<EventsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<EventsController>

        [HttpPost]
        public void Post([FromBody] Event newEvent)
        {
            events.Add(new Event { Id = 2, Title =newEvent.Title  }); 
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
