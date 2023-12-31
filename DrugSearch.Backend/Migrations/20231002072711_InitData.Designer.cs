﻿// <auto-generated />
using System;
using DrugSearch.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DrugSearch.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231002072711_InitData")]
    partial class InitData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DrugSearch.Models.Drug", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("DrugStoreId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DrugStoreId");

                    b.ToTable("Drugs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("44cdee61-7f5f-4e10-9adf-1c7d35e425f9"),
                            Description = "Paracetamol is a common pain reliever and fever reducer.",
                            DrugStoreId = new Guid("7a62649b-0a6f-47b5-a32a-ade59a80d476"),
                            Name = "Paracetamol",
                            Price = "328.59"
                        },
                        new
                        {
                            Id = new Guid("a1e49c08-4c6b-432b-a496-c87f08a9a60d"),
                            Description = "Ibuprofen is a nonsteroidal anti-inflammatory drug (NSAID) used to relieve pain, reduce inflammation, and lower fever.",
                            DrugStoreId = new Guid("8c57711d-5ecb-4e6f-8ec6-cb00513247d8"),
                            Name = "Ibuprofen",
                            Price = "917.49"
                        },
                        new
                        {
                            Id = new Guid("f9c4dc90-5417-49ee-a4a1-7d5602956b9f"),
                            Description = "Omeprazole is used to reduce stomach acid production and treat conditions like stomach and esophagus ulcers and acid reflux.",
                            DrugStoreId = new Guid("85d716d3-6154-41a4-86a7-b4afd8cc7bd0"),
                            Name = "Omeprazole",
                            Price = "939.28"
                        },
                        new
                        {
                            Id = new Guid("af507cc4-0e18-443e-ba1d-b0b9239de2ff"),
                            Description = "Amoxicillin is an antibiotic used to treat bacterial infections, including respiratory and urinary tract infections.",
                            DrugStoreId = new Guid("8c57711d-5ecb-4e6f-8ec6-cb00513247d8"),
                            Name = "Amoxicillin",
                            Price = "203.61"
                        },
                        new
                        {
                            Id = new Guid("bb225f3b-c1e1-488f-adaa-5b4c9b094fb0"),
                            Description = "Simvastatin is a medication that lowers cholesterol levels in the blood, reducing the risk of heart disease.",
                            DrugStoreId = new Guid("9b3502bc-a2d6-4f8b-bef3-6484df106873"),
                            Name = "Simvastatin",
                            Price = "917.74"
                        },
                        new
                        {
                            Id = new Guid("42327e89-f9bf-4396-a453-4817825dba65"),
                            Description = "Levothyroxine is used to treat an underactive thyroid gland (hypothyroidism) and maintain normal metabolism.",
                            DrugStoreId = new Guid("6eefb17a-a179-45de-aeb9-64db91846d72"),
                            Name = "Levothyroxine",
                            Price = "950.43"
                        },
                        new
                        {
                            Id = new Guid("c955e599-282d-4933-9075-963fdd75b4c1"),
                            Description = "Metformin is a drug used to treat type 2 diabetes by lowering blood sugar levels.",
                            DrugStoreId = new Guid("744c9e2f-61df-4465-a051-ce5113da09a5"),
                            Name = "Metformin",
                            Price = "581.32"
                        },
                        new
                        {
                            Id = new Guid("9abfd28f-7395-47d6-b04d-19d9d8d6e033"),
                            Description = "Lisinopril is an angiotensin-converting enzyme (ACE) inhibitor used to lower high blood pressure and treat heart failure.",
                            DrugStoreId = new Guid("51fbd9ab-c30f-46e0-bd15-8bc999ed046b"),
                            Name = "Lisinopril",
                            Price = "545.97"
                        },
                        new
                        {
                            Id = new Guid("9b7746bf-a3fa-45ef-b943-3c7862ad3199"),
                            Description = "Aspirin is commonly used as a pain reliever and anti-inflammatory agent, as well as for its blood-thinning properties.",
                            DrugStoreId = new Guid("3b4b6c51-2e9d-43d2-87b0-1831deb6a4dc"),
                            Name = "Aspirin",
                            Price = "988.29"
                        },
                        new
                        {
                            Id = new Guid("e31d1c9f-c216-4d24-ae2e-e681800933eb"),
                            Description = "Atorvastatin is a medication used to lower cholesterol levels and reduce the risk of cardiovascular diseases.",
                            DrugStoreId = new Guid("2ded6f35-0c0d-4727-b76f-dbef03c16e8a"),
                            Name = "Atorvastatin",
                            Price = "326.47"
                        },
                        new
                        {
                            Id = new Guid("42ade0fa-760a-4046-8586-cf246cca6e0e"),
                            Description = "Albuterol is a bronchodilator used to relieve symptoms of asthma and chronic obstructive pulmonary disease (COPD).",
                            DrugStoreId = new Guid("8f3f0277-523d-4c14-a039-e521c1cf8e0e"),
                            Name = "Albuterol",
                            Price = "669.25"
                        },
                        new
                        {
                            Id = new Guid("20ef1956-3463-40f1-bd03-4e8cf9581c46"),
                            Description = "Prednisone is a corticosteroid medication used to reduce inflammation and suppress the immune system.",
                            DrugStoreId = new Guid("3a015fe0-f354-4e6a-b836-799919905442"),
                            Name = "Prednisone",
                            Price = "581.01"
                        },
                        new
                        {
                            Id = new Guid("eb8a72f3-8bcb-4f43-bed4-320ce980e91b"),
                            Description = "Ciprofloxacin is an antibiotic used to treat a variety of bacterial infections, including urinary tract and skin infections.",
                            DrugStoreId = new Guid("071e109a-4678-4758-8b30-95003a673abb"),
                            Name = "Ciprofloxacin",
                            Price = "680.50"
                        },
                        new
                        {
                            Id = new Guid("e066007c-a76c-4cc0-b911-51429d7a66ee"),
                            Description = "Losartan is an angiotensin II receptor blocker (ARB) used to treat high blood pressure and protect the kidneys in diabetes.",
                            DrugStoreId = new Guid("6b2229ff-055b-4b3c-8433-c91fb9cee0d3"),
                            Name = "Losartan",
                            Price = "625.76"
                        },
                        new
                        {
                            Id = new Guid("10303ac2-bc6a-4e8a-be56-b90be3293377"),
                            Description = "Hydrochlorothiazide is a diuretic used to treat high blood pressure and reduce fluid retention.",
                            DrugStoreId = new Guid("e7c169c6-87a0-4ae1-bb35-aa565ae8d650"),
                            Name = "Hydrochlorothiazide",
                            Price = "494.16"
                        },
                        new
                        {
                            Id = new Guid("ccb148c7-3c69-4b4b-8a27-1f4a47c33dae"),
                            Description = "Amlodipine is a calcium channel blocker used to treat high blood pressure and angina (chest pain).",
                            DrugStoreId = new Guid("d6c46906-390d-41a6-8709-6f45a5487dd4"),
                            Name = "Amlodipine",
                            Price = "68.44"
                        },
                        new
                        {
                            Id = new Guid("834a69ec-1a13-4594-9f13-42209aee30f8"),
                            Description = "Metoprolol is a beta-blocker used to treat high blood pressure and prevent heart attacks and migraines.",
                            DrugStoreId = new Guid("d6c46906-390d-41a6-8709-6f45a5487dd4"),
                            Name = "Metoprolol",
                            Price = "164.58"
                        },
                        new
                        {
                            Id = new Guid("927755a9-1f27-47c4-8a3a-e1175e61d8ed"),
                            Description = "Warfarin is an anticoagulant (blood thinner) used to prevent blood clots and strokes.",
                            DrugStoreId = new Guid("a5566167-d14b-4306-9693-2d94ef2b99e5"),
                            Name = "Warfarin",
                            Price = "302.45"
                        },
                        new
                        {
                            Id = new Guid("44bc5a24-746c-436f-a16c-d36a90a709b3"),
                            Description = "Diazepam is a benzodiazepine used to treat anxiety, muscle spasms, and seizures.",
                            DrugStoreId = new Guid("3b4b6c51-2e9d-43d2-87b0-1831deb6a4dc"),
                            Name = "Diazepam",
                            Price = "190.88"
                        },
                        new
                        {
                            Id = new Guid("792d771f-7704-4f3b-8790-a8b8d5fe07a7"),
                            Description = "Loratadine is an antihistamine used to relieve allergy symptoms such as sneezing, runny nose, and itching.",
                            DrugStoreId = new Guid("8785aab3-44d4-4128-84a4-acc02b01f7ec"),
                            Name = "Loratadine",
                            Price = "518.36"
                        },
                        new
                        {
                            Id = new Guid("59d8a16c-b7e1-4f05-a23e-9f08d21c4721"),
                            Description = "Fluoxetine is an antidepressant medication used to treat depression, obsessive-compulsive disorder (OCD), and panic disorder.",
                            DrugStoreId = new Guid("3a015fe0-f354-4e6a-b836-799919905442"),
                            Name = "Fluoxetine",
                            Price = "670.91"
                        },
                        new
                        {
                            Id = new Guid("3e49f107-5c2a-4daf-95d9-b7736dcaba74"),
                            Description = "Citalopram is an antidepressant medication used to treat depression and anxiety disorders.",
                            DrugStoreId = new Guid("6b2229ff-055b-4b3c-8433-c91fb9cee0d3"),
                            Name = "Citalopram",
                            Price = "712.96"
                        },
                        new
                        {
                            Id = new Guid("0fb09f09-24bc-4524-9cc8-6f279bd62e76"),
                            Description = "Venlafaxine is an antidepressant used to treat major depressive disorder and generalized anxiety disorder.",
                            DrugStoreId = new Guid("d6c46906-390d-41a6-8709-6f45a5487dd4"),
                            Name = "Venlafaxine",
                            Price = "481.82"
                        },
                        new
                        {
                            Id = new Guid("44b23e66-eb41-496b-af9c-8ec3daf33cc1"),
                            Description = "Olanzapine is an antipsychotic medication used to treat schizophrenia and bipolar disorder.",
                            DrugStoreId = new Guid("6b2229ff-055b-4b3c-8433-c91fb9cee0d3"),
                            Name = "Olanzapine",
                            Price = "621.00"
                        },
                        new
                        {
                            Id = new Guid("df0986ad-c65e-4e6c-8333-527bf9f903d8"),
                            Description = "Ranitidine is an H2 blocker used to reduce stomach acid and relieve conditions like heartburn and ulcers.",
                            DrugStoreId = new Guid("9fc79c51-4fa1-488b-840f-e758e4bf2c72"),
                            Name = "Ranitidine",
                            Price = "361.36"
                        },
                        new
                        {
                            Id = new Guid("deeb0a07-5778-42d6-aab0-603889559248"),
                            Description = "Hydrocodone is an opioid pain medication used to relieve moderate to severe pain.",
                            DrugStoreId = new Guid("2ded6f35-0c0d-4727-b76f-dbef03c16e8a"),
                            Name = "Hydrocodone",
                            Price = "740.03"
                        },
                        new
                        {
                            Id = new Guid("0c18faa8-8b79-44b7-b0e4-c454096c6469"),
                            Description = "Tramadol is a synthetic opioid used to treat moderate to severe pain.",
                            DrugStoreId = new Guid("d5d43ce7-b013-45eb-96ed-2672ac6f37ab"),
                            Name = "Tramadol",
                            Price = "269.95"
                        });
                });

            modelBuilder.Entity("DrugSearch.Models.DrugStore", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Contacts")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DrugStores");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9c0d3cdd-7d31-4889-be3b-7ac4510e94cc"),
                            Address = "East Haven:5823 Mozell Island",
                            Contacts = "474-441-2702",
                            Name = "Lubowitz Inc"
                        },
                        new
                        {
                            Id = new Guid("cfbb6ac5-cb69-4404-8aab-7612d1b9a329"),
                            Address = "Bransontown:1007 Armstrong Divide",
                            Contacts = "(377) 391-1501",
                            Name = "Hagenes, Shanahan and Yost"
                        },
                        new
                        {
                            Id = new Guid("1ebdd60d-cf2e-4a70-ac83-82e1e05f8d8c"),
                            Address = "New Shanie:68944 Wolf Cliffs",
                            Contacts = "680.342.8316",
                            Name = "Schimmel Group"
                        },
                        new
                        {
                            Id = new Guid("d6c46906-390d-41a6-8709-6f45a5487dd4"),
                            Address = "South Deborah:7511 Jolie Well",
                            Contacts = "(652) 386-6012 x1706",
                            Name = "Conn - Price"
                        },
                        new
                        {
                            Id = new Guid("fd09a144-512e-4256-b64c-ffe59bfe2f3f"),
                            Address = "West Jasen:811 Brekke Stravenue",
                            Contacts = "809-823-7954",
                            Name = "Schuppe - Labadie"
                        },
                        new
                        {
                            Id = new Guid("2ded6f35-0c0d-4727-b76f-dbef03c16e8a"),
                            Address = "East Adityafort:8215 Shawn Estates",
                            Contacts = "(772) 996-1485",
                            Name = "Schaefer, Hayes and Blanda"
                        },
                        new
                        {
                            Id = new Guid("85d716d3-6154-41a4-86a7-b4afd8cc7bd0"),
                            Address = "Moseberg:285 Devante Meadows",
                            Contacts = "(641) 266-0178 x49160",
                            Name = "Price - Oberbrunner"
                        },
                        new
                        {
                            Id = new Guid("6eefb17a-a179-45de-aeb9-64db91846d72"),
                            Address = "East Arnaldoberg:78030 Markus Parks",
                            Contacts = "556-322-6861",
                            Name = "Reinger LLC"
                        },
                        new
                        {
                            Id = new Guid("7a62649b-0a6f-47b5-a32a-ade59a80d476"),
                            Address = "Port Ardella:80064 Ezequiel Avenue",
                            Contacts = "461.241.7817",
                            Name = "Mosciski - VonRueden"
                        },
                        new
                        {
                            Id = new Guid("a5566167-d14b-4306-9693-2d94ef2b99e5"),
                            Address = "Port Marcel:6410 O'Hara Cape",
                            Contacts = "(587) 961-7684",
                            Name = "Schmidt LLC"
                        },
                        new
                        {
                            Id = new Guid("d5d43ce7-b013-45eb-96ed-2672ac6f37ab"),
                            Address = "West Stacyton:2546 Swift Corners",
                            Contacts = "1-637-848-8608 x143",
                            Name = "Harris - Larkin"
                        },
                        new
                        {
                            Id = new Guid("2cda5a5e-5ed4-4934-bf4e-a1c783856d4d"),
                            Address = "West Tyrel:524 Robel Curve",
                            Contacts = "1-445-345-4678",
                            Name = "Dickens, Fahey and Senger"
                        },
                        new
                        {
                            Id = new Guid("744c9e2f-61df-4465-a051-ce5113da09a5"),
                            Address = "New Weldon:925 Libbie Square",
                            Contacts = "(216) 873-9270",
                            Name = "MacGyver - Rice"
                        },
                        new
                        {
                            Id = new Guid("071e109a-4678-4758-8b30-95003a673abb"),
                            Address = "Erdmanstad:838 Kling Way",
                            Contacts = "562.588.2644 x9055",
                            Name = "Pfannerstill - Greenholt"
                        },
                        new
                        {
                            Id = new Guid("6b2229ff-055b-4b3c-8433-c91fb9cee0d3"),
                            Address = "Lake Nathanael:7922 Keeling Cape",
                            Contacts = "(741) 354-3342",
                            Name = "Swift, Kihn and Cormier"
                        },
                        new
                        {
                            Id = new Guid("3a015fe0-f354-4e6a-b836-799919905442"),
                            Address = "North Jaymemouth:97805 Strosin Mills",
                            Contacts = "1-974-545-8959",
                            Name = "Kozey - Marquardt"
                        },
                        new
                        {
                            Id = new Guid("8c57711d-5ecb-4e6f-8ec6-cb00513247d8"),
                            Address = "East Verda:309 Bo Islands",
                            Contacts = "680-793-4571 x39616",
                            Name = "Predovic Inc"
                        },
                        new
                        {
                            Id = new Guid("449d34a3-1e09-4619-b2fb-ea31d14816a2"),
                            Address = "Torphyberg:582 Haag Spurs",
                            Contacts = "1-629-639-0424 x1656",
                            Name = "Adams - Gleason"
                        },
                        new
                        {
                            Id = new Guid("51fbd9ab-c30f-46e0-bd15-8bc999ed046b"),
                            Address = "Kuhicstad:44810 Luettgen Rapids",
                            Contacts = "492-919-0569 x87607",
                            Name = "Russel, Waelchi and White"
                        },
                        new
                        {
                            Id = new Guid("b812cd4d-6921-419d-a4fd-05fb7820fef7"),
                            Address = "North Giovannaport:211 Cheyenne Track",
                            Contacts = "295.663.0289",
                            Name = "DuBuque - Wuckert"
                        },
                        new
                        {
                            Id = new Guid("bdd77089-80be-4a82-9043-be9de05da68a"),
                            Address = "South Liam:622 Braxton Squares",
                            Contacts = "542-344-2600",
                            Name = "Kerluke - Roob"
                        },
                        new
                        {
                            Id = new Guid("8fbf962c-b6d2-4505-a6e3-14bfd9b21269"),
                            Address = "Wisokyton:036 Kassulke Ramp",
                            Contacts = "926-604-8487",
                            Name = "Wintheiser LLC"
                        },
                        new
                        {
                            Id = new Guid("8f3f0277-523d-4c14-a039-e521c1cf8e0e"),
                            Address = "Bergstromstad:68123 Marley Cape",
                            Contacts = "382-916-6585",
                            Name = "Schowalter - Hettinger"
                        },
                        new
                        {
                            Id = new Guid("9b3502bc-a2d6-4f8b-bef3-6484df106873"),
                            Address = "Simoniston:64660 Patrick Court",
                            Contacts = "435-618-2219 x487",
                            Name = "Yost, O'Connell and Daugherty"
                        },
                        new
                        {
                            Id = new Guid("8785aab3-44d4-4128-84a4-acc02b01f7ec"),
                            Address = "Schimmelburgh:15502 Mertz Cliffs",
                            Contacts = "346-218-0273 x899",
                            Name = "Kuphal and Sons"
                        },
                        new
                        {
                            Id = new Guid("cf60ebb4-d9ee-4f28-8a75-1086303c2f07"),
                            Address = "North Rosemarieland:43569 Ismael Ports",
                            Contacts = "307.959.1967",
                            Name = "Bechtelar - Mann"
                        },
                        new
                        {
                            Id = new Guid("c29ff7b4-4f22-4445-b74e-4c1770fbed44"),
                            Address = "Markusville:5842 Fay Villages",
                            Contacts = "1-358-250-0656",
                            Name = "Blick, Zieme and Fahey"
                        },
                        new
                        {
                            Id = new Guid("3b4b6c51-2e9d-43d2-87b0-1831deb6a4dc"),
                            Address = "New Jettie:145 Cale Burg",
                            Contacts = "1-274-554-8646 x955",
                            Name = "Gerhold, Mohr and Lemke"
                        },
                        new
                        {
                            Id = new Guid("9fc79c51-4fa1-488b-840f-e758e4bf2c72"),
                            Address = "West Marianside:4768 Deja Hill",
                            Contacts = "1-651-314-6409 x69497",
                            Name = "Monahan - Pfannerstill"
                        },
                        new
                        {
                            Id = new Guid("e7c169c6-87a0-4ae1-bb35-aa565ae8d650"),
                            Address = "West Gunner:66721 William Wells",
                            Contacts = "(630) 846-9693 x6050",
                            Name = "Morissette - Kreiger"
                        });
                });

            modelBuilder.Entity("DrugSearch.Models.Drug", b =>
                {
                    b.HasOne("DrugSearch.Models.DrugStore", "DrugStore")
                        .WithMany("drugs")
                        .HasForeignKey("DrugStoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DrugStore");
                });

            modelBuilder.Entity("DrugSearch.Models.DrugStore", b =>
                {
                    b.Navigation("drugs");
                });
#pragma warning restore 612, 618
        }
    }
}
