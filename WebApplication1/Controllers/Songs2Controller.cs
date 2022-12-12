using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Songs2Controller : ControllerBase
    {
        private static List<Song> songs = new List<Song>()
        {
            new Song(){Id=0,Title="Guachu Guey", Language="ES"},
            new Song(){Id=1,Title="Guachu Guey", Language="EN"}
        };

        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return songs;
        }

        [HttpPost]
        public void Post([FromBody] Song song)
        {
            songs.Add(song);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Song song)
        {
            songs[id] = song;
        }
    }
}
