using Newtonsoft.Json;

namespace DrugSearch.Models
{
    public class Drug
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Price { get; set; }

        [JsonIgnore]
        public DrugStore? DrugStore { get; set; }
        public Guid DrugStoreId { get; set; }
    }
}
