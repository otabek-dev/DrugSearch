using DrugSearch.Models;
using Microsoft.EntityFrameworkCore;

namespace DrugSearch.DB
{
    public class AppDbConfig
    {
        private readonly ModelBuilder _modelBuilder;

        public AppDbConfig(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        private static Dictionary<string, string> drugs = new() 
        {
            {"Paracetamol", "Paracetamol is a common pain reliever and fever reducer."},
            {"Ibuprofen", "Ibuprofen is a nonsteroidal anti-inflammatory drug (NSAID) used to relieve pain, reduce inflammation, and lower fever."},
            {"Omeprazole", "Omeprazole is used to reduce stomach acid production and treat conditions like stomach and esophagus ulcers and acid reflux."},
            {"Amoxicillin", "Amoxicillin is an antibiotic used to treat bacterial infections, including respiratory and urinary tract infections."},
            {"Simvastatin", "Simvastatin is a medication that lowers cholesterol levels in the blood, reducing the risk of heart disease."},
            {"Levothyroxine", "Levothyroxine is used to treat an underactive thyroid gland (hypothyroidism) and maintain normal metabolism."},
            {"Metformin", "Metformin is a drug used to treat type 2 diabetes by lowering blood sugar levels."},
            {"Lisinopril", "Lisinopril is an angiotensin-converting enzyme (ACE) inhibitor used to lower high blood pressure and treat heart failure."},
            {"Aspirin", "Aspirin is commonly used as a pain reliever and anti-inflammatory agent, as well as for its blood-thinning properties."},
            {"Atorvastatin", "Atorvastatin is a medication used to lower cholesterol levels and reduce the risk of cardiovascular diseases."},
            {"Albuterol", "Albuterol is a bronchodilator used to relieve symptoms of asthma and chronic obstructive pulmonary disease (COPD)."},
            {"Prednisone", "Prednisone is a corticosteroid medication used to reduce inflammation and suppress the immune system."},
            {"Ciprofloxacin", "Ciprofloxacin is an antibiotic used to treat a variety of bacterial infections, including urinary tract and skin infections."},
            {"Losartan", "Losartan is an angiotensin II receptor blocker (ARB) used to treat high blood pressure and protect the kidneys in diabetes."},
            {"Hydrochlorothiazide", "Hydrochlorothiazide is a diuretic used to treat high blood pressure and reduce fluid retention."},
            {"Amlodipine", "Amlodipine is a calcium channel blocker used to treat high blood pressure and angina (chest pain)."},
            {"Metoprolol", "Metoprolol is a beta-blocker used to treat high blood pressure and prevent heart attacks and migraines."},
            {"Warfarin", "Warfarin is an anticoagulant (blood thinner) used to prevent blood clots and strokes."},
            {"Diazepam", "Diazepam is a benzodiazepine used to treat anxiety, muscle spasms, and seizures."},
            {"Loratadine", "Loratadine is an antihistamine used to relieve allergy symptoms such as sneezing, runny nose, and itching."},
            {"Fluoxetine", "Fluoxetine is an antidepressant medication used to treat depression, obsessive-compulsive disorder (OCD), and panic disorder."},
            {"Citalopram", "Citalopram is an antidepressant medication used to treat depression and anxiety disorders."},
            {"Venlafaxine", "Venlafaxine is an antidepressant used to treat major depressive disorder and generalized anxiety disorder."},
            {"Olanzapine", "Olanzapine is an antipsychotic medication used to treat schizophrenia and bipolar disorder."},
            {"Ranitidine", "Ranitidine is an H2 blocker used to reduce stomach acid and relieve conditions like heartburn and ulcers."},
            {"Hydrocodone", "Hydrocodone is an opioid pain medication used to relieve moderate to severe pain."},
            {"Tramadol", "Tramadol is a synthetic opioid used to treat moderate to severe pain."},
        };

        public void Configure()
        {
            var drugStores = new List<DrugStore>();

            for (int i = 0; i < 30; i++)
            {
                var faker = new Bogus.Faker();
                var drugStore = new DrugStore()
                {
                    Id = Guid.NewGuid(),
                    Address = faker.Address.City() + ":" + faker.Address.StreetAddress(),
                    Contacts = faker.Phone.PhoneNumber(),
                    Name = faker.Company.CompanyName()
                };

                drugStores.Add(drugStore);
                _modelBuilder.Entity<DrugStore>().HasData(drugStore);
            }

            foreach(var drug in drugs)
            {
                var faker = new Bogus.Faker();

                var entity = new Drug()
                {
                    Id = Guid.NewGuid(),
                    Name = drug.Key,
                    Description = drug.Value,
                    Price = faker.Commerce.Price(),
                    DrugStoreId = drugStores[faker.Random.Int(0, 29)].Id
                };

                _modelBuilder.Entity<Drug>().HasData(entity);
            }
        }
    }
}
