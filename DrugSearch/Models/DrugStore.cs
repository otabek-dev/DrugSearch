namespace DrugSearch.Models
{
    public class DrugStore
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Address { get; set; }
        public required string Contacts { get; set; }

        public List<Drug> drugs { get; set; } = new();
    }
}
