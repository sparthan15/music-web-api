using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {

        private ApiDbContext _dbContext;

        public SongsController(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/<SongsController>
        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return _dbContext.Songs;
        }

        // GET api/<SongsController>/5
        [HttpGet("{id}")]
        public Song Get(int id)
        {
            return _dbContext.Songs.Find(id);
        }

        // POST api/<SongsController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Song song)
        {
            _dbContext.Add(song);
            await _dbContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<SongsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Song song)
        {
            Song songToUpdate = _dbContext.Songs.Find(id);
            songToUpdate.Title = song.Title;
            songToUpdate.Language = song.Language;
        }

        // DELETE api/<SongsController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var songToDelete = _dbContext.Songs.Find(id);
            _dbContext.Songs.Remove(songToDelete);
            await _dbContext.SaveChangesAsync();
            return Ok("Record deleted!");
        }
    }
}
