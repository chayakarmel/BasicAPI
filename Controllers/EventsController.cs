using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private static int id = 0;
        private static List<Event> events = new List<Event> { 
            new Event { Id = ++id, Title = "title1",Start= DateTime.Now}, 
            new Event { Id = ++id, Title = "title2", Start = DateTime.Now }
        };

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
        //public Event Get(int id)
        //{
        //    return events.Find(e => e.Id == id);
        //}

        // POST api/<EventsController>

        [HttpPost]
        public Event Post([FromBody] Event newEvent)
        {
            
            events.Add(new Event { Id = ++id, Title = newEvent.Title, Start = newEvent.Start });
            return newEvent;
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public Event Put(int id, [FromBody] Event newEvent)
        {
            Event temp=events.Find(e => e.Id == id);    
            temp.Id=newEvent.Id;
            temp.Title=newEvent.Title;
            temp.Start = newEvent.Start;
            return newEvent;
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Event temp = events.Find(e => e.Id == id);
            events.Remove(temp);    
        }
    }
}
