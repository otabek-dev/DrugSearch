namespace DrugSearch.ViewModel
{
    public class DrugPriceInDrugStoreViewModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public List<DrugStoreViewModel>? DrugStoreViewModel { get; set; }
    }
}
