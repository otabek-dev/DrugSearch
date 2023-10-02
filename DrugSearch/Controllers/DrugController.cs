using DrugSearch.DB;
using DrugSearch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DrugSearch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrugController : ControllerBase
    {
        private AppDbContext _context;

        public DrugController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Drug> Get()
        {
            var drugs = _context.Drugs.Include(d => d.DrugStore);
            return drugs;
        }

        [HttpGet("{id}")]
        public string Get(Guid id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
        }
    }
}
