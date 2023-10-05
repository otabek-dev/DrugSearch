using DrugSearch.DB;
using DrugSearch.Models;
using DrugSearch.Services;
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
        private DrugService _drugSearchService;

        public DrugController(DrugService drugSearchService)
        {
            _drugSearchService = drugSearchService;
        }

        [HttpGet("{id}")]
        public DrugPriceInDrugStoreViewModel Get(Guid id)
        {
            var result = _drugSearchService.GetDrugPricesByDrugId(id);
            return result;
        }

        [HttpGet("search")]
        public IEnumerable<DrugViewModel> Get([FromQuery] string query)
        {
            var result = _drugSearchService.SearchDrugs(query);
            return result;
        }
    }
}
