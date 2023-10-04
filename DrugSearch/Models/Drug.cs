namespace DrugSearch.Models
{
    public class Drug
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }

        public List<DrugPriceInDrugStore> PricesInDrugStores { get; set; } = new();
    }
}
