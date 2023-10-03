using DrugSearch.DB;
using DrugSearch.Models;
using DrugSearch.ViewModel;
using Korzh.EasyQuery.Linq;
using Microsoft.EntityFrameworkCore;

namespace DrugSearch.Services
{
    public class DrugService
    {
        private AppDbContext _context;

        public DrugService(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        public DrugViewModel GetDrugById(Guid id)
        {
            var drug = _context.Drugs
                .Where(d => d.Id == id)
                .FirstOrDefault();
            if (drug is null) 
                return null;

            _context.DrugStores.Where(ds => ds.Id == drug.DrugStoreId).Load();
            return GetDrugViewModel(drug);
        }

        public List<DrugViewModel> SearchDrugs(string query)
        {
            var result = _context.Drugs
                .FullTextSearchQuery(query)
                .Include(d => d.DrugStore)
                .ToList()
                .Select(GetDrugViewModel);

            return result.ToList();
        }

        private DrugViewModel GetDrugViewModel(Drug drug)
        {
            return new()
            {
                Id = drug.Id,
                Name = drug.Name,
                Description = drug.Description,
                Price = drug.Price,
                DrugStoreName = drug.DrugStore.Name,
                DrugStoreAddress = drug.DrugStore.Address,
                DrugStoreContact = drug.DrugStore.Contacts
            };
        }
    }
}
