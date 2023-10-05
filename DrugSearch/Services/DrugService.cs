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

        public DrugPriceInDrugStoreViewModel GetDrugPricesByDrugId(Guid id)
        {
            var drug = _context.Drugs
                .Where(d => d.Id == id)
                .Include(d => d.PricesInDrugStores)
                    .ThenInclude(prds => prds.DrugStore)
                .FirstOrDefault();
            if (drug is null)
                return null;

            return GetDrugViewModel(drug);
        }

        public List<DrugViewModel> SearchDrugs(string query)
        {
            var result = _context.Drugs
                .Where(p => EF.Functions.Like(p.Name.ToLower(), $"%{query.ToLower()}%"))
                .Select(drug => new DrugViewModel()
                {
                    Id = drug.Id,
                    Name = drug.Name,
                    Description = drug.Description
                });

            return result.ToList();
        }

        public List<DrugViewModel> GetAllDrugs()
        {
            var result = _context.Drugs
                .ToList()
                .Select(drug => new DrugViewModel()
                {
                    Id = drug.Id,
                    Name = drug.Name,
                    Description = drug.Description
                });

            return result.ToList();
        }

        private DrugPriceInDrugStoreViewModel GetDrugViewModel(Drug drug)
        {
            var drugViewModel = new DrugPriceInDrugStoreViewModel()
            {
                Id = drug.Id,
                Name = drug.Name,
                Description = drug.Description,
                DrugStoreViewModel = new()
            };

            foreach (var drugPrice in drug.PricesInDrugStores)
            {
                drugViewModel.DrugStoreViewModel.Add(new()
                {
                    Price = drugPrice.Price,
                    DrugStoreName = drugPrice.DrugStore?.Name,
                    DrugStoreAddress = drugPrice.DrugStore?.Address,
                    DrugStoreContact = drugPrice.DrugStore?.Contacts
                });
            }

            return drugViewModel;
        }
    }
}
