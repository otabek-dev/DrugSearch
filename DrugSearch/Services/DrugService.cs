﻿using DrugSearch.DB;
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

        public List<DrugPriceInDrugStoreViewModel> GetDrugPricesByDrugId(Guid id)
        {
            var drug = _context.Drugs
                .Where(d => d.Id == id)
                .Include(d => d.PricesInDrugStores)
                    .ThenInclude(prds =>  prds.DrugStore)
                .FirstOrDefault();
            if (drug is null)
                return null;

           // _context.DrugPriceInDrugStores.Where(ds => ds.DrugId == drug.Id).Load();
            
            return GetDrugViewModel(drug);
        }

        public List<DrugViewModel> SearchDrugs(string query)
        {
            var result = _context.Drugs
                .FullTextSearchQuery(query)
                .ToList()
                .Select(drug => new DrugViewModel()
                {
                    Id = drug.Id,
                    Name = drug.Name,
                    Description = drug.Description
                });

            return result.ToList();
        }

        private List<DrugPriceInDrugStoreViewModel> GetDrugViewModel(Drug drug)
        {
            var drugViewModel = new List<DrugPriceInDrugStoreViewModel>();

            foreach (var drugPrice in drug.PricesInDrugStores)
            {
                drugViewModel.Add(new()
                {
                    Id = drug.Id,
                    Name = drug.Name,
                    Description = drug.Description,
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
