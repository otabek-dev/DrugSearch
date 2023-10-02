using DrugSearch.DB;
using DrugSearch.ViewModel;
using Korzh.EasyQuery.Linq;
using Microsoft.EntityFrameworkCore;

namespace DrugSearch.Services
{
    public class DrugSearchService
    {
        private AppDbContext _context;

        public DrugSearchService(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        public List<DrugViewModel> GetDrugs(string query)
        {
            var drugs = _context.Drugs
                .FullTextSearchQuery(query)
                .Include(d => d.DrugStore);

            var result = new List<DrugViewModel>();
            foreach (var drug in drugs)
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
    }
}
