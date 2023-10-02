using DrugSearch.DB;
using DrugSearch.Models;
using DrugSearch.ViewModel;
using Korzh.EasyQuery.Linq;
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

        //[HttpGet]
        //public IEnumerable<Drug> Get()
        //{
        //    var drugs = _context.Drugs.Include(d => d.DrugStore);
            
        //    return drugs;
        //}

        [HttpGet]
        public IEnumerable<DrugViewModel> Get([FromQuery] string query)
        {
            var drugs = _context.Drugs
                .FullTextSearchQuery(query)
                .Include(d => d.DrugStore);

            var result = new List<DrugViewModel>();
            foreach(var drug in drugs)
            {
                result.Add(new()
                {
                    Name = drug.Name,
                    Description = drug.Description,
                    Price = drug.Price,
                    DrugStoreName = drug.DrugStore.Name,
                    DrugStoreAddress = drug.DrugStore.Address,
                    DrugStoreContact = drug.DrugStore.Contacts
                });
            }

            return result;
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
