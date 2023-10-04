using Newtonsoft.Json;

namespace DrugSearch.Models
{
    public class DrugPriceInDrugStore
    {
        public Guid Id { get; set; }
        public Guid DrugId { get; set; }
        public Guid DrugStoreId { get; set; }
        public decimal Price { get; set; }

        [JsonIgnore]
        public Drug? Drug { get; set; }
        [JsonIgnore]
        public DrugStore? DrugStore { get; set; }

    }
}
