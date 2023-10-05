using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrugSearch.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewModelDrugPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drugs_DrugStores_DrugStoreId",
                table: "Drugs");

            migrationBuilder.DropIndex(
                name: "IX_Drugs_DrugStoreId",
                table: "Drugs");

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("1ebdd60d-cf2e-4a70-ac83-82e1e05f8d8c"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("2cda5a5e-5ed4-4934-bf4e-a1c783856d4d"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("449d34a3-1e09-4619-b2fb-ea31d14816a2"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("8fbf962c-b6d2-4505-a6e3-14bfd9b21269"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("9c0d3cdd-7d31-4889-be3b-7ac4510e94cc"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("b812cd4d-6921-419d-a4fd-05fb7820fef7"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("bdd77089-80be-4a82-9043-be9de05da68a"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("c29ff7b4-4f22-4445-b74e-4c1770fbed44"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("cf60ebb4-d9ee-4f28-8a75-1086303c2f07"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("cfbb6ac5-cb69-4404-8aab-7612d1b9a329"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("fd09a144-512e-4256-b64c-ffe59bfe2f3f"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("0c18faa8-8b79-44b7-b0e4-c454096c6469"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("0fb09f09-24bc-4524-9cc8-6f279bd62e76"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("10303ac2-bc6a-4e8a-be56-b90be3293377"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("20ef1956-3463-40f1-bd03-4e8cf9581c46"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("3e49f107-5c2a-4daf-95d9-b7736dcaba74"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("42327e89-f9bf-4396-a453-4817825dba65"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("42ade0fa-760a-4046-8586-cf246cca6e0e"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("44b23e66-eb41-496b-af9c-8ec3daf33cc1"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("44bc5a24-746c-436f-a16c-d36a90a709b3"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("44cdee61-7f5f-4e10-9adf-1c7d35e425f9"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("59d8a16c-b7e1-4f05-a23e-9f08d21c4721"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("792d771f-7704-4f3b-8790-a8b8d5fe07a7"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("834a69ec-1a13-4594-9f13-42209aee30f8"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("927755a9-1f27-47c4-8a3a-e1175e61d8ed"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("9abfd28f-7395-47d6-b04d-19d9d8d6e033"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("9b7746bf-a3fa-45ef-b943-3c7862ad3199"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("a1e49c08-4c6b-432b-a496-c87f08a9a60d"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("af507cc4-0e18-443e-ba1d-b0b9239de2ff"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("bb225f3b-c1e1-488f-adaa-5b4c9b094fb0"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("c955e599-282d-4933-9075-963fdd75b4c1"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("ccb148c7-3c69-4b4b-8a27-1f4a47c33dae"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("deeb0a07-5778-42d6-aab0-603889559248"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("df0986ad-c65e-4e6c-8333-527bf9f903d8"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("e066007c-a76c-4cc0-b911-51429d7a66ee"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("e31d1c9f-c216-4d24-ae2e-e681800933eb"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("eb8a72f3-8bcb-4f43-bed4-320ce980e91b"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("f9c4dc90-5417-49ee-a4a1-7d5602956b9f"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("071e109a-4678-4758-8b30-95003a673abb"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("2ded6f35-0c0d-4727-b76f-dbef03c16e8a"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("3a015fe0-f354-4e6a-b836-799919905442"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("3b4b6c51-2e9d-43d2-87b0-1831deb6a4dc"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("51fbd9ab-c30f-46e0-bd15-8bc999ed046b"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("6b2229ff-055b-4b3c-8433-c91fb9cee0d3"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("6eefb17a-a179-45de-aeb9-64db91846d72"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("744c9e2f-61df-4465-a051-ce5113da09a5"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("7a62649b-0a6f-47b5-a32a-ade59a80d476"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("85d716d3-6154-41a4-86a7-b4afd8cc7bd0"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("8785aab3-44d4-4128-84a4-acc02b01f7ec"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("8c57711d-5ecb-4e6f-8ec6-cb00513247d8"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("8f3f0277-523d-4c14-a039-e521c1cf8e0e"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("9b3502bc-a2d6-4f8b-bef3-6484df106873"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("9fc79c51-4fa1-488b-840f-e758e4bf2c72"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("a5566167-d14b-4306-9693-2d94ef2b99e5"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("d5d43ce7-b013-45eb-96ed-2672ac6f37ab"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("d6c46906-390d-41a6-8709-6f45a5487dd4"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("e7c169c6-87a0-4ae1-bb35-aa565ae8d650"));

            migrationBuilder.DropColumn(
                name: "DrugStoreId",
                table: "Drugs");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Drugs");

            migrationBuilder.CreateTable(
                name: "DrugPriceInDrugStores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DrugId = table.Column<Guid>(type: "uuid", nullable: false),
                    DrugStoreId = table.Column<Guid>(type: "uuid", nullable: false),
                    Price = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugPriceInDrugStores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DrugPriceInDrugStores_DrugStores_DrugStoreId",
                        column: x => x.DrugStoreId,
                        principalTable: "DrugStores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DrugPriceInDrugStores_Drugs_DrugId",
                        column: x => x.DrugId,
                        principalTable: "Drugs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DrugStores",
                columns: new[] { "Id", "Address", "Contacts", "Name" },
                values: new object[,]
                {
                    { new Guid("00a43880-fba6-4bcb-a6bf-b5266cc37cc1"), "Justynfort:03722 Waelchi Square", "915.731.6722 x9769", "D'Amore, Schmitt and Cremin" },
                    { new Guid("02bdbad6-270a-4f24-b010-16813b51458e"), "Williamsonhaven:53793 Conn Shoal", "514.580.0098 x7000", "Barton and Sons" },
                    { new Guid("0316a52a-0705-4032-8668-87a163cd24eb"), "Lake Biankatown:465 Quigley Haven", "(676) 256-7187", "McKenzie LLC" },
                    { new Guid("03b4ea4d-fdb7-4fd6-8712-e9f0e6e6b44a"), "North Molly:5556 Welch Cliffs", "(946) 343-5131 x584", "Hegmann - Turner" },
                    { new Guid("19deb140-7279-4ca5-bac3-73145c984eaa"), "Reillyberg:059 Tanya Shoal", "(304) 525-9436 x77433", "White - Cruickshank" },
                    { new Guid("21eadb08-69ef-4f82-9771-c9415149c423"), "Nicolasview:403 Claud Land", "482.815.2507 x93736", "Hodkiewicz LLC" },
                    { new Guid("3a79102b-cb9e-45c0-8877-20c3b6890837"), "Port Khalilton:95007 Judah Cove", "1-309-782-4070", "D'Amore - Mertz" },
                    { new Guid("433c9768-284c-4829-b415-e2c1d0012e3e"), "Lake Otho:377 Kailee Trace", "326-657-0416 x42908", "Champlin, Labadie and Windler" },
                    { new Guid("4c0f3608-1be9-4ed0-ba9d-20641fcbb490"), "New Milford:6814 Deshawn Ramp", "(569) 978-6169 x594", "McClure, Pfannerstill and Gulgowski" },
                    { new Guid("57a9cd69-d6d5-48f9-835a-44095282bebc"), "East Scarlett:98921 Schowalter Walk", "1-286-744-1088 x168", "Murazik - Kohler" },
                    { new Guid("5a773426-4389-483a-b748-4144532e4913"), "Mikeborough:7443 Margot Row", "666.362.5412 x54257", "Corkery LLC" },
                    { new Guid("5ea71807-f78f-4b19-8ea6-babab2e7781d"), "West Jeanside:784 Heaney Land", "1-883-731-3046 x03725", "Ritchie, Bahringer and Hegmann" },
                    { new Guid("5eafb1b6-86b0-4647-9b77-a43cc5e9aea5"), "East Emmaleefurt:2164 Greenfelder Station", "571-655-7024 x4302", "Tromp Group" },
                    { new Guid("60e1cfe3-c98b-42d1-a209-92465012d3bc"), "Port Yolandafurt:07013 Ankunding Lake", "(349) 556-2220", "Cronin - Cummerata" },
                    { new Guid("643581f2-d085-4f62-8a47-baa00b277bd8"), "Huelfort:0194 Terry Canyon", "(993) 484-2981", "Haley - Breitenberg" },
                    { new Guid("6c6ed7f9-9339-41b7-abfd-fabaa640b734"), "Port Henryberg:06592 Dare Throughway", "802-465-8816", "Hayes - Bartell" },
                    { new Guid("796e0970-cac2-4f7d-a04a-1bc961d05a69"), "Handstad:63209 Jacques Views", "(847) 677-7128", "Jacobi, Ortiz and Barrows" },
                    { new Guid("7d9c34f7-2003-4b15-8200-b40dd9672678"), "Lake Casimirfurt:80581 Clifton Fords", "989-587-3252", "Harris - Hermiston" },
                    { new Guid("862a3b4f-5ceb-4895-97bb-7919a1d1f40d"), "South Ceceliabury:63349 Gulgowski Gardens", "593-896-9427", "Gerhold, Mills and Lowe" },
                    { new Guid("9b52f1ea-ca88-4613-b091-961398151380"), "Mariahtown:505 Kirlin Stravenue", "463-866-7649 x8043", "Wintheiser, Kub and Moore" },
                    { new Guid("a14244f9-4bc6-413b-8503-01bc9e5078cd"), "East Isom:370 Krajcik Viaduct", "(749) 823-5507", "Schimmel, Abbott and Rice" },
                    { new Guid("b15eaab4-e9cf-438f-a925-ab648b2d10f8"), "South Nellaville:1381 Roosevelt Prairie", "215.736.2362", "Cremin Group" },
                    { new Guid("b7528e58-a216-4e2f-9077-37bd279278ce"), "Morganmouth:075 Dicki Way", "270-887-1926 x1787", "Hansen Group" },
                    { new Guid("bebfc552-251d-4cfa-8662-fa491c9bcf03"), "East Everettburgh:3378 Roob Fords", "1-204-927-7758 x8134", "Mante, Gleason and Towne" },
                    { new Guid("cae44210-02f9-441e-b1c0-6bce58fed681"), "Stoltenbergland:71387 Hamill Coves", "220-426-1990", "Stoltenberg Inc" },
                    { new Guid("d2455801-22ba-446a-91fa-f4517cfdb26e"), "North Rosemarieton:84495 Shaina Island", "906.950.0805 x62176", "Langworth - Bashirian" },
                    { new Guid("da03d3fb-54f0-4a7a-acec-c9e5ded9fc9c"), "Angelaville:5596 Deron Forks", "1-359-699-6608", "McDermott LLC" },
                    { new Guid("e5f3e4b3-42f4-4cfa-9880-2448bde780c8"), "Port Wilsonfort:107 Horace Turnpike", "784.894.8140", "Botsford Inc" },
                    { new Guid("f3c8caf2-57ab-48d0-889b-88512dc17c63"), "Harrismouth:3526 Justine Crossroad", "1-632-825-8400 x1687", "Ondricka - Bashirian" },
                    { new Guid("fc9ab48d-2a34-45ad-858b-dc8875a2b7b6"), "Christophechester:33390 Von Via", "778.727.4032 x2435", "Carter, Schiller and Green" }
                });

            migrationBuilder.InsertData(
                table: "Drugs",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("056a9d5d-a3bc-41c9-9f13-7da629eb2cb1"), "Losartan is an angiotensin II receptor blocker (ARB) used to treat high blood pressure and protect the kidneys in diabetes.", "Losartan" },
                    { new Guid("09532631-d42f-4b8e-bd74-9fb8c8b94f3f"), "Warfarin is an anticoagulant (blood thinner) used to prevent blood clots and strokes.", "Warfarin" },
                    { new Guid("2158eec6-0a03-4921-b7f0-8fd6f11fa1cd"), "Diazepam is a benzodiazepine used to treat anxiety, muscle spasms, and seizures.", "Diazepam" },
                    { new Guid("396f317e-6b80-489d-aa7c-a7e7a63e2cd1"), "Levothyroxine is used to treat an underactive thyroid gland (hypothyroidism) and maintain normal metabolism.", "Levothyroxine" },
                    { new Guid("44662994-9fd9-4835-92ac-41403a6d0c9d"), "Ranitidine is an H2 blocker used to reduce stomach acid and relieve conditions like heartburn and ulcers.", "Ranitidine" },
                    { new Guid("4a67d79a-af3e-4252-bd6d-754664b8246d"), "Prednisone is a corticosteroid medication used to reduce inflammation and suppress the immune system.", "Prednisone" },
                    { new Guid("5575b1b0-14fc-43a4-bc7c-e18d3ff492f0"), "Ciprofloxacin is an antibiotic used to treat a variety of bacterial infections, including urinary tract and skin infections.", "Ciprofloxacin" },
                    { new Guid("614cc30c-d136-4350-b66b-9d0e67ca3d4d"), "Albuterol is a bronchodilator used to relieve symptoms of asthma and chronic obstructive pulmonary disease (COPD).", "Albuterol" },
                    { new Guid("62befa9f-8f33-4340-91af-5460b996fe0d"), "Fluoxetine is an antidepressant medication used to treat depression, obsessive-compulsive disorder (OCD), and panic disorder.", "Fluoxetine" },
                    { new Guid("642ee04e-a9cf-4bdd-8133-ed5c04506d0d"), "Has a positive effect on brain metabolic processes, increases the concentration of ATP in brain tissue", "Piracetam" },
                    { new Guid("6876a1bd-41b8-438d-9e28-d38d59493e74"), "Loratadine is an antihistamine used to relieve allergy symptoms such as sneezing, runny nose, and itching.", "Loratadine" },
                    { new Guid("6b658814-9de3-4a35-b75a-4e7578c4ae99"), "Metformin is a drug used to treat type 2 diabetes by lowering blood sugar levels.", "Metformin" },
                    { new Guid("6dda5905-01de-4fcf-9fad-6d4151df79ad"), "Amoxicillin is an antibiotic used to treat bacterial infections, including respiratory and urinary tract infections.", "Amoxicillin" },
                    { new Guid("96861ef9-0127-4357-8bdc-958e8bf25c1c"), "Omeprazole is used to reduce stomach acid production and treat conditions like stomach and esophagus ulcers and acid reflux.", "Omeprazole" },
                    { new Guid("9a03bc77-4857-4afa-bc3d-340afacdf525"), "Simvastatin is a medication that lowers cholesterol levels in the blood, reducing the risk of heart disease.", "Simvastatin" },
                    { new Guid("9b8d3ac5-d3b1-43f1-a78b-28838fd6de73"), "Ibuprofen is a nonsteroidal anti-inflammatory drug (NSAID) used to relieve pain, reduce inflammation, and lower fever.", "Ibuprofen" },
                    { new Guid("9cc16471-34d6-46d4-84f0-0bd955067cec"), "Metoprolol is a beta-blocker used to treat high blood pressure and prevent heart attacks and migraines.", "Metoprolol" },
                    { new Guid("acfdf482-80ac-43e5-bc5c-93f9854fd7e6"), "Tramadol is a synthetic opioid used to treat moderate to severe pain.", "Tramadol" },
                    { new Guid("b11391bd-84fd-4afc-ae7e-bfab9a75965f"), "Lisinopril is an angiotensin-converting enzyme (ACE) inhibitor used to lower high blood pressure and treat heart failure.", "Lisinopril" },
                    { new Guid("b39ef71d-f523-4368-b267-6ff4a4b19f70"), "Amlodipine is a calcium channel blocker used to treat high blood pressure and angina (chest pain).", "Amlodipine" },
                    { new Guid("cade813a-ba72-4a30-9348-653a3d731dc4"), "Aspirin is commonly used as a pain reliever and anti-inflammatory agent, as well as for its blood-thinning properties.", "Aspirin" },
                    { new Guid("cb59beb1-735e-4d0c-94e3-1bcd1d33e8ec"), "Paracetamol is a common pain reliever and fever reducer.", "Paracetamol" },
                    { new Guid("da014c12-c152-48f1-bcc2-68e96ed2a284"), "Atorvastatin is a medication used to lower cholesterol levels and reduce the risk of cardiovascular diseases.", "Atorvastatin" },
                    { new Guid("e02726a6-2517-4043-b3bd-d0a6324f8b0b"), "Hydrochlorothiazide is a diuretic used to treat high blood pressure and reduce fluid retention.", "Hydrochlorothiazide" },
                    { new Guid("e2910069-5293-4740-b7ff-e34e69645db4"), "Citalopram is an antidepressant medication used to treat depression and anxiety disorders.", "Citalopram" },
                    { new Guid("f3b33f0a-a46b-431b-b4f4-b66b83077049"), "Hydrocodone is an opioid pain medication used to relieve moderate to severe pain.", "Hydrocodone" },
                    { new Guid("fb9e2de2-5576-4ddb-8150-72cc0201bbb9"), "Venlafaxine is an antidepressant used to treat major depressive disorder and generalized anxiety disorder.", "Venlafaxine" },
                    { new Guid("ff38b942-8e0e-446a-95b9-4ea765ffbe41"), "Olanzapine is an antipsychotic medication used to treat schizophrenia and bipolar disorder.", "Olanzapine" }
                });

            migrationBuilder.InsertData(
                table: "DrugPriceInDrugStores",
                columns: new[] { "Id", "DrugId", "DrugStoreId", "Price" },
                values: new object[,]
                {
                    { new Guid("0a806e88-34ca-430f-a7af-37c274713f5b"), new Guid("e2910069-5293-4740-b7ff-e34e69645db4"), new Guid("5eafb1b6-86b0-4647-9b77-a43cc5e9aea5"), "12.36" },
                    { new Guid("0b7877b0-dc85-4b1f-9a3f-0ff30b5443f5"), new Guid("da014c12-c152-48f1-bcc2-68e96ed2a284"), new Guid("5a773426-4389-483a-b748-4144532e4913"), "10.06" },
                    { new Guid("0d7e827d-c0df-4282-a12b-7d4a239810e8"), new Guid("642ee04e-a9cf-4bdd-8133-ed5c04506d0d"), new Guid("6c6ed7f9-9339-41b7-abfd-fabaa640b734"), "19.64" },
                    { new Guid("0dbb8012-6a4e-467a-9a50-4ff21a14f921"), new Guid("96861ef9-0127-4357-8bdc-958e8bf25c1c"), new Guid("19deb140-7279-4ca5-bac3-73145c984eaa"), "7.61" },
                    { new Guid("0f088d08-a155-4852-b3fe-172f760368e5"), new Guid("b39ef71d-f523-4368-b267-6ff4a4b19f70"), new Guid("21eadb08-69ef-4f82-9771-c9415149c423"), "13.88" },
                    { new Guid("162f7ca2-1570-484f-883e-a34c4b2fefd2"), new Guid("b11391bd-84fd-4afc-ae7e-bfab9a75965f"), new Guid("433c9768-284c-4829-b415-e2c1d0012e3e"), "17.93" },
                    { new Guid("17d1aa38-edbf-4966-b908-8c6410a5d105"), new Guid("b11391bd-84fd-4afc-ae7e-bfab9a75965f"), new Guid("4c0f3608-1be9-4ed0-ba9d-20641fcbb490"), "20.40" },
                    { new Guid("18238bdb-81d2-4aea-8e66-cc1c9fab8798"), new Guid("62befa9f-8f33-4340-91af-5460b996fe0d"), new Guid("00a43880-fba6-4bcb-a6bf-b5266cc37cc1"), "16.42" },
                    { new Guid("1aca2a3b-3623-4af4-bff7-8a5e19f2e321"), new Guid("da014c12-c152-48f1-bcc2-68e96ed2a284"), new Guid("57a9cd69-d6d5-48f9-835a-44095282bebc"), "16.87" },
                    { new Guid("1c3f30ce-5f32-48d3-b13b-908cb45234c9"), new Guid("642ee04e-a9cf-4bdd-8133-ed5c04506d0d"), new Guid("7d9c34f7-2003-4b15-8200-b40dd9672678"), "8.86" },
                    { new Guid("1d398d3a-f9c1-46a9-a719-a53ee4a7fa32"), new Guid("e2910069-5293-4740-b7ff-e34e69645db4"), new Guid("643581f2-d085-4f62-8a47-baa00b277bd8"), "11.88" },
                    { new Guid("1f2b9799-7843-47d8-847a-eba01242e437"), new Guid("614cc30c-d136-4350-b66b-9d0e67ca3d4d"), new Guid("03b4ea4d-fdb7-4fd6-8712-e9f0e6e6b44a"), "8.67" },
                    { new Guid("29595e47-7139-4bf6-9b9a-70047617d03f"), new Guid("09532631-d42f-4b8e-bd74-9fb8c8b94f3f"), new Guid("3a79102b-cb9e-45c0-8877-20c3b6890837"), "12.23" },
                    { new Guid("2b3ee27c-f7a1-48fd-a4f0-23a19779262b"), new Guid("09532631-d42f-4b8e-bd74-9fb8c8b94f3f"), new Guid("da03d3fb-54f0-4a7a-acec-c9e5ded9fc9c"), "14.00" },
                    { new Guid("33c57d80-3e08-4e85-9667-05a5d9bae391"), new Guid("b11391bd-84fd-4afc-ae7e-bfab9a75965f"), new Guid("0316a52a-0705-4032-8668-87a163cd24eb"), "29.94" },
                    { new Guid("3525e67d-0862-485d-8716-0a4d869de805"), new Guid("acfdf482-80ac-43e5-bc5c-93f9854fd7e6"), new Guid("00a43880-fba6-4bcb-a6bf-b5266cc37cc1"), "29.79" },
                    { new Guid("3730ac58-500e-4518-8abf-fdefc2b1af8a"), new Guid("cb59beb1-735e-4d0c-94e3-1bcd1d33e8ec"), new Guid("433c9768-284c-4829-b415-e2c1d0012e3e"), "10.16" },
                    { new Guid("3b4ba9b2-3b95-4af9-8bee-89fc93550ab5"), new Guid("9b8d3ac5-d3b1-43f1-a78b-28838fd6de73"), new Guid("796e0970-cac2-4f7d-a04a-1bc961d05a69"), "10.53" },
                    { new Guid("4434ecee-d588-48df-ab8b-2b0dd9948b05"), new Guid("6b658814-9de3-4a35-b75a-4e7578c4ae99"), new Guid("9b52f1ea-ca88-4613-b091-961398151380"), "21.01" },
                    { new Guid("44e34f4f-8c00-45d9-8dbf-ba3039635045"), new Guid("9b8d3ac5-d3b1-43f1-a78b-28838fd6de73"), new Guid("5eafb1b6-86b0-4647-9b77-a43cc5e9aea5"), "14.06" },
                    { new Guid("44fb2e35-7608-4448-bccb-df0030fc3d82"), new Guid("b11391bd-84fd-4afc-ae7e-bfab9a75965f"), new Guid("60e1cfe3-c98b-42d1-a209-92465012d3bc"), "15.29" },
                    { new Guid("46427edf-1373-4a2f-b982-51d914d4532b"), new Guid("ff38b942-8e0e-446a-95b9-4ea765ffbe41"), new Guid("5ea71807-f78f-4b19-8ea6-babab2e7781d"), "13.79" },
                    { new Guid("4a4af062-d479-44c0-970e-0b518ec30c65"), new Guid("44662994-9fd9-4835-92ac-41403a6d0c9d"), new Guid("9b52f1ea-ca88-4613-b091-961398151380"), "28.13" },
                    { new Guid("4dbd2104-7a42-477b-81a8-3eb7d1aae05f"), new Guid("cb59beb1-735e-4d0c-94e3-1bcd1d33e8ec"), new Guid("fc9ab48d-2a34-45ad-858b-dc8875a2b7b6"), "28.96" },
                    { new Guid("4f992bd7-9656-4848-9e42-01fa90d366cc"), new Guid("b11391bd-84fd-4afc-ae7e-bfab9a75965f"), new Guid("796e0970-cac2-4f7d-a04a-1bc961d05a69"), "20.59" },
                    { new Guid("4ff2e184-20bd-4fa6-9a65-dbb0bd78737a"), new Guid("9b8d3ac5-d3b1-43f1-a78b-28838fd6de73"), new Guid("60e1cfe3-c98b-42d1-a209-92465012d3bc"), "7.66" },
                    { new Guid("5003b66f-ed62-4db8-a05c-bf23a4801d5b"), new Guid("396f317e-6b80-489d-aa7c-a7e7a63e2cd1"), new Guid("3a79102b-cb9e-45c0-8877-20c3b6890837"), "27.77" },
                    { new Guid("64208bd6-5565-4626-b5cb-479a78e3cd68"), new Guid("ff38b942-8e0e-446a-95b9-4ea765ffbe41"), new Guid("00a43880-fba6-4bcb-a6bf-b5266cc37cc1"), "24.56" },
                    { new Guid("65f80904-326a-4c24-b13c-47aa9099b001"), new Guid("056a9d5d-a3bc-41c9-9f13-7da629eb2cb1"), new Guid("862a3b4f-5ceb-4895-97bb-7919a1d1f40d"), "23.26" },
                    { new Guid("6ce75acc-204e-4074-be30-a5e04dd961b9"), new Guid("642ee04e-a9cf-4bdd-8133-ed5c04506d0d"), new Guid("19deb140-7279-4ca5-bac3-73145c984eaa"), "25.10" },
                    { new Guid("6d1f3ca4-9377-4fee-8f6a-e429f7fc2367"), new Guid("9a03bc77-4857-4afa-bc3d-340afacdf525"), new Guid("d2455801-22ba-446a-91fa-f4517cfdb26e"), "22.76" },
                    { new Guid("6de6ef74-1b66-4d46-9c0a-e8bfa8453331"), new Guid("9b8d3ac5-d3b1-43f1-a78b-28838fd6de73"), new Guid("03b4ea4d-fdb7-4fd6-8712-e9f0e6e6b44a"), "13.58" },
                    { new Guid("6e0cc39a-8c5a-4754-bd27-53b10502da97"), new Guid("5575b1b0-14fc-43a4-bc7c-e18d3ff492f0"), new Guid("f3c8caf2-57ab-48d0-889b-88512dc17c63"), "7.25" },
                    { new Guid("708daccc-445b-4d50-a74c-c07426a3fef4"), new Guid("f3b33f0a-a46b-431b-b4f4-b66b83077049"), new Guid("4c0f3608-1be9-4ed0-ba9d-20641fcbb490"), "22.82" },
                    { new Guid("757baba0-a7aa-465e-b0e1-70ddc543fe0e"), new Guid("642ee04e-a9cf-4bdd-8133-ed5c04506d0d"), new Guid("02bdbad6-270a-4f24-b010-16813b51458e"), "22.76" },
                    { new Guid("76fdc025-9cbd-4309-b508-5ce8c0fb11e2"), new Guid("5575b1b0-14fc-43a4-bc7c-e18d3ff492f0"), new Guid("643581f2-d085-4f62-8a47-baa00b277bd8"), "17.53" },
                    { new Guid("7a9a4b18-3737-4347-87bd-9d04861b6973"), new Guid("acfdf482-80ac-43e5-bc5c-93f9854fd7e6"), new Guid("03b4ea4d-fdb7-4fd6-8712-e9f0e6e6b44a"), "15.08" },
                    { new Guid("7ead413c-e7d8-405a-832c-6211e1de8753"), new Guid("4a67d79a-af3e-4252-bd6d-754664b8246d"), new Guid("cae44210-02f9-441e-b1c0-6bce58fed681"), "6.83" },
                    { new Guid("7ebf8b7b-fa63-41e8-bd82-22d847a73068"), new Guid("cb59beb1-735e-4d0c-94e3-1bcd1d33e8ec"), new Guid("433c9768-284c-4829-b415-e2c1d0012e3e"), "21.26" },
                    { new Guid("8096be36-b953-4e06-a2b0-955bcb1e617b"), new Guid("ff38b942-8e0e-446a-95b9-4ea765ffbe41"), new Guid("4c0f3608-1be9-4ed0-ba9d-20641fcbb490"), "6.66" },
                    { new Guid("8344eaed-32d1-47a3-acd9-11423bd92943"), new Guid("642ee04e-a9cf-4bdd-8133-ed5c04506d0d"), new Guid("b7528e58-a216-4e2f-9077-37bd279278ce"), "6.49" },
                    { new Guid("844ac382-1725-4101-9c2e-46dcd8fdc023"), new Guid("9b8d3ac5-d3b1-43f1-a78b-28838fd6de73"), new Guid("b15eaab4-e9cf-438f-a925-ab648b2d10f8"), "29.23" },
                    { new Guid("875f2fc2-da95-4e4c-a1d3-0989f59b3b38"), new Guid("62befa9f-8f33-4340-91af-5460b996fe0d"), new Guid("21eadb08-69ef-4f82-9771-c9415149c423"), "28.77" },
                    { new Guid("89e6e2f6-3898-4e07-8e10-6bc8d461bb7a"), new Guid("acfdf482-80ac-43e5-bc5c-93f9854fd7e6"), new Guid("a14244f9-4bc6-413b-8503-01bc9e5078cd"), "14.07" },
                    { new Guid("8b209f23-84b0-4a55-a20a-ecc4d6b21ac3"), new Guid("44662994-9fd9-4835-92ac-41403a6d0c9d"), new Guid("b7528e58-a216-4e2f-9077-37bd279278ce"), "21.47" },
                    { new Guid("8fd931db-bb6c-4d4e-9f41-42f086b22cc3"), new Guid("fb9e2de2-5576-4ddb-8150-72cc0201bbb9"), new Guid("d2455801-22ba-446a-91fa-f4517cfdb26e"), "12.59" },
                    { new Guid("930d976c-9ff4-45b8-a2cc-82cc3d310c45"), new Guid("056a9d5d-a3bc-41c9-9f13-7da629eb2cb1"), new Guid("19deb140-7279-4ca5-bac3-73145c984eaa"), "22.73" },
                    { new Guid("97b60c84-e1fe-4a43-a495-eef876102406"), new Guid("9b8d3ac5-d3b1-43f1-a78b-28838fd6de73"), new Guid("0316a52a-0705-4032-8668-87a163cd24eb"), "5.52" },
                    { new Guid("9b4a54cf-a252-46b7-b83e-dd3bf4635b11"), new Guid("e2910069-5293-4740-b7ff-e34e69645db4"), new Guid("7d9c34f7-2003-4b15-8200-b40dd9672678"), "15.92" },
                    { new Guid("9b818068-52a4-4eba-b755-2100f93fd9b8"), new Guid("5575b1b0-14fc-43a4-bc7c-e18d3ff492f0"), new Guid("3a79102b-cb9e-45c0-8877-20c3b6890837"), "28.00" },
                    { new Guid("9ebda6f9-4ae8-4202-91cb-6bb627f95606"), new Guid("cb59beb1-735e-4d0c-94e3-1bcd1d33e8ec"), new Guid("0316a52a-0705-4032-8668-87a163cd24eb"), "28.79" },
                    { new Guid("a2287229-b23c-4493-b643-0c1098e0e513"), new Guid("6b658814-9de3-4a35-b75a-4e7578c4ae99"), new Guid("bebfc552-251d-4cfa-8662-fa491c9bcf03"), "8.68" },
                    { new Guid("a5733622-33cf-408d-a988-72eed7bbc794"), new Guid("62befa9f-8f33-4340-91af-5460b996fe0d"), new Guid("f3c8caf2-57ab-48d0-889b-88512dc17c63"), "24.98" },
                    { new Guid("a5978995-a1c1-45f8-976c-0349b334098b"), new Guid("614cc30c-d136-4350-b66b-9d0e67ca3d4d"), new Guid("5ea71807-f78f-4b19-8ea6-babab2e7781d"), "24.86" },
                    { new Guid("a72a8b64-559a-4bb9-a19e-53dba69d2298"), new Guid("f3b33f0a-a46b-431b-b4f4-b66b83077049"), new Guid("cae44210-02f9-441e-b1c0-6bce58fed681"), "21.17" },
                    { new Guid("a81eaa75-8a10-4341-a78a-69bb1e812598"), new Guid("9cc16471-34d6-46d4-84f0-0bd955067cec"), new Guid("6c6ed7f9-9339-41b7-abfd-fabaa640b734"), "19.85" },
                    { new Guid("a9db64fd-1a1b-4004-9d6f-b9cba7b6138b"), new Guid("acfdf482-80ac-43e5-bc5c-93f9854fd7e6"), new Guid("e5f3e4b3-42f4-4cfa-9880-2448bde780c8"), "14.22" },
                    { new Guid("aa830359-4125-4e5e-88e1-ba5199122006"), new Guid("9a03bc77-4857-4afa-bc3d-340afacdf525"), new Guid("a14244f9-4bc6-413b-8503-01bc9e5078cd"), "21.99" },
                    { new Guid("ae245c83-4861-4eff-8203-5ed552845325"), new Guid("cade813a-ba72-4a30-9348-653a3d731dc4"), new Guid("bebfc552-251d-4cfa-8662-fa491c9bcf03"), "25.63" },
                    { new Guid("b298b245-622f-47a4-9f28-fa62947d589f"), new Guid("cade813a-ba72-4a30-9348-653a3d731dc4"), new Guid("796e0970-cac2-4f7d-a04a-1bc961d05a69"), "15.90" },
                    { new Guid("b32590b1-cf79-484a-a417-26b18160f237"), new Guid("4a67d79a-af3e-4252-bd6d-754664b8246d"), new Guid("b7528e58-a216-4e2f-9077-37bd279278ce"), "21.82" },
                    { new Guid("ba2ef979-3a3b-44d2-b739-4c2036534b16"), new Guid("614cc30c-d136-4350-b66b-9d0e67ca3d4d"), new Guid("b15eaab4-e9cf-438f-a925-ab648b2d10f8"), "14.92" },
                    { new Guid("bebe1ecc-28fd-4ab3-a40a-d57a82b71243"), new Guid("6b658814-9de3-4a35-b75a-4e7578c4ae99"), new Guid("fc9ab48d-2a34-45ad-858b-dc8875a2b7b6"), "20.47" },
                    { new Guid("c426b5ad-f99b-481f-9aef-3608006ebba9"), new Guid("9cc16471-34d6-46d4-84f0-0bd955067cec"), new Guid("02bdbad6-270a-4f24-b010-16813b51458e"), "25.37" },
                    { new Guid("c51fcba5-46b4-4d5f-ae57-79bf9db03f8d"), new Guid("acfdf482-80ac-43e5-bc5c-93f9854fd7e6"), new Guid("7d9c34f7-2003-4b15-8200-b40dd9672678"), "16.36" },
                    { new Guid("c97eea41-aeaf-48f2-8a76-e66bd64478a3"), new Guid("96861ef9-0127-4357-8bdc-958e8bf25c1c"), new Guid("862a3b4f-5ceb-4895-97bb-7919a1d1f40d"), "6.94" },
                    { new Guid("cedacbe7-f9f6-4c7e-b414-81a23798fc94"), new Guid("b39ef71d-f523-4368-b267-6ff4a4b19f70"), new Guid("60e1cfe3-c98b-42d1-a209-92465012d3bc"), "19.54" },
                    { new Guid("d1ab3619-380a-4272-bb07-aef46a676673"), new Guid("cade813a-ba72-4a30-9348-653a3d731dc4"), new Guid("bebfc552-251d-4cfa-8662-fa491c9bcf03"), "23.68" },
                    { new Guid("d33402f4-5efe-477f-b972-ab383ccb034a"), new Guid("ff38b942-8e0e-446a-95b9-4ea765ffbe41"), new Guid("5a773426-4389-483a-b748-4144532e4913"), "22.96" },
                    { new Guid("d559f5aa-e908-418d-b091-78ce4e3ac092"), new Guid("cade813a-ba72-4a30-9348-653a3d731dc4"), new Guid("5ea71807-f78f-4b19-8ea6-babab2e7781d"), "21.07" },
                    { new Guid("d5e11f88-ef6e-46d3-97b6-3551aeae12fa"), new Guid("6dda5905-01de-4fcf-9fad-6d4151df79ad"), new Guid("57a9cd69-d6d5-48f9-835a-44095282bebc"), "26.75" },
                    { new Guid("d9214414-2956-4553-a37d-45f6aa24c824"), new Guid("da014c12-c152-48f1-bcc2-68e96ed2a284"), new Guid("57a9cd69-d6d5-48f9-835a-44095282bebc"), "8.76" },
                    { new Guid("dc8b22ad-5a89-47ac-bf94-470353a3ff31"), new Guid("ff38b942-8e0e-446a-95b9-4ea765ffbe41"), new Guid("5a773426-4389-483a-b748-4144532e4913"), "6.25" },
                    { new Guid("e14713b7-7d0c-45c9-8eda-659f675e4c12"), new Guid("b39ef71d-f523-4368-b267-6ff4a4b19f70"), new Guid("6c6ed7f9-9339-41b7-abfd-fabaa640b734"), "21.94" },
                    { new Guid("e564749a-7a26-48f2-9151-7b2f27a2cf1a"), new Guid("ff38b942-8e0e-446a-95b9-4ea765ffbe41"), new Guid("02bdbad6-270a-4f24-b010-16813b51458e"), "7.03" },
                    { new Guid("e594f847-2731-45c6-a8e8-d815273a221a"), new Guid("b39ef71d-f523-4368-b267-6ff4a4b19f70"), new Guid("a14244f9-4bc6-413b-8503-01bc9e5078cd"), "13.84" },
                    { new Guid("e5bec5e1-ed7f-4700-8616-5e3d7d91f20e"), new Guid("2158eec6-0a03-4921-b7f0-8fd6f11fa1cd"), new Guid("862a3b4f-5ceb-4895-97bb-7919a1d1f40d"), "26.54" },
                    { new Guid("e9efb5eb-d09f-4953-beb1-4e23da7498e4"), new Guid("4a67d79a-af3e-4252-bd6d-754664b8246d"), new Guid("e5f3e4b3-42f4-4cfa-9880-2448bde780c8"), "17.52" },
                    { new Guid("ea91ef8d-4da6-4640-85ba-3c758b7a2bdd"), new Guid("6dda5905-01de-4fcf-9fad-6d4151df79ad"), new Guid("21eadb08-69ef-4f82-9771-c9415149c423"), "25.27" },
                    { new Guid("ec30762b-23b1-43ed-bb4b-861478f539a2"), new Guid("f3b33f0a-a46b-431b-b4f4-b66b83077049"), new Guid("da03d3fb-54f0-4a7a-acec-c9e5ded9fc9c"), "27.79" },
                    { new Guid("ee7f00ca-03f4-4636-8396-155515272e1a"), new Guid("e02726a6-2517-4043-b3bd-d0a6324f8b0b"), new Guid("cae44210-02f9-441e-b1c0-6bce58fed681"), "26.71" },
                    { new Guid("ef5cbf89-9ade-4273-9923-b0de28557e8f"), new Guid("e2910069-5293-4740-b7ff-e34e69645db4"), new Guid("b15eaab4-e9cf-438f-a925-ab648b2d10f8"), "22.99" },
                    { new Guid("ef66cae1-85b2-40c3-ba9b-ef91bdd54d27"), new Guid("9a03bc77-4857-4afa-bc3d-340afacdf525"), new Guid("5eafb1b6-86b0-4647-9b77-a43cc5e9aea5"), "9.60" },
                    { new Guid("eff2feb1-0879-492c-a5d2-82abb4335a12"), new Guid("62befa9f-8f33-4340-91af-5460b996fe0d"), new Guid("9b52f1ea-ca88-4613-b091-961398151380"), "23.68" },
                    { new Guid("f0b3d2bb-0529-4096-a88a-6105374a79db"), new Guid("44662994-9fd9-4835-92ac-41403a6d0c9d"), new Guid("fc9ab48d-2a34-45ad-858b-dc8875a2b7b6"), "14.46" },
                    { new Guid("f79bed48-a50f-4d84-b947-99e449caf3f9"), new Guid("b39ef71d-f523-4368-b267-6ff4a4b19f70"), new Guid("e5f3e4b3-42f4-4cfa-9880-2448bde780c8"), "18.80" },
                    { new Guid("f7f18371-e68c-40e6-a47c-d3bb97c6f976"), new Guid("9cc16471-34d6-46d4-84f0-0bd955067cec"), new Guid("f3c8caf2-57ab-48d0-889b-88512dc17c63"), "11.10" },
                    { new Guid("f8df53ac-dc7a-4a77-89b0-2c0e951db717"), new Guid("fb9e2de2-5576-4ddb-8150-72cc0201bbb9"), new Guid("d2455801-22ba-446a-91fa-f4517cfdb26e"), "16.02" },
                    { new Guid("fe9f8f1c-f4ac-4b20-9eb3-5e142bf5e4cb"), new Guid("e2910069-5293-4740-b7ff-e34e69645db4"), new Guid("643581f2-d085-4f62-8a47-baa00b277bd8"), "17.71" },
                    { new Guid("ff60fde6-3b1d-4962-a631-c038f7a91ce2"), new Guid("614cc30c-d136-4350-b66b-9d0e67ca3d4d"), new Guid("da03d3fb-54f0-4a7a-acec-c9e5ded9fc9c"), "11.37" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DrugPriceInDrugStores_DrugId",
                table: "DrugPriceInDrugStores",
                column: "DrugId");

            migrationBuilder.CreateIndex(
                name: "IX_DrugPriceInDrugStores_DrugStoreId",
                table: "DrugPriceInDrugStores",
                column: "DrugStoreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DrugPriceInDrugStores");

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("00a43880-fba6-4bcb-a6bf-b5266cc37cc1"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("02bdbad6-270a-4f24-b010-16813b51458e"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("0316a52a-0705-4032-8668-87a163cd24eb"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("03b4ea4d-fdb7-4fd6-8712-e9f0e6e6b44a"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("19deb140-7279-4ca5-bac3-73145c984eaa"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("21eadb08-69ef-4f82-9771-c9415149c423"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("3a79102b-cb9e-45c0-8877-20c3b6890837"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("433c9768-284c-4829-b415-e2c1d0012e3e"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("4c0f3608-1be9-4ed0-ba9d-20641fcbb490"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("57a9cd69-d6d5-48f9-835a-44095282bebc"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("5a773426-4389-483a-b748-4144532e4913"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("5ea71807-f78f-4b19-8ea6-babab2e7781d"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("5eafb1b6-86b0-4647-9b77-a43cc5e9aea5"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("60e1cfe3-c98b-42d1-a209-92465012d3bc"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("643581f2-d085-4f62-8a47-baa00b277bd8"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("6c6ed7f9-9339-41b7-abfd-fabaa640b734"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("796e0970-cac2-4f7d-a04a-1bc961d05a69"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("7d9c34f7-2003-4b15-8200-b40dd9672678"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("862a3b4f-5ceb-4895-97bb-7919a1d1f40d"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("9b52f1ea-ca88-4613-b091-961398151380"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("a14244f9-4bc6-413b-8503-01bc9e5078cd"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("b15eaab4-e9cf-438f-a925-ab648b2d10f8"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("b7528e58-a216-4e2f-9077-37bd279278ce"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("bebfc552-251d-4cfa-8662-fa491c9bcf03"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("cae44210-02f9-441e-b1c0-6bce58fed681"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("d2455801-22ba-446a-91fa-f4517cfdb26e"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("da03d3fb-54f0-4a7a-acec-c9e5ded9fc9c"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("e5f3e4b3-42f4-4cfa-9880-2448bde780c8"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("f3c8caf2-57ab-48d0-889b-88512dc17c63"));

            migrationBuilder.DeleteData(
                table: "DrugStores",
                keyColumn: "Id",
                keyValue: new Guid("fc9ab48d-2a34-45ad-858b-dc8875a2b7b6"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("056a9d5d-a3bc-41c9-9f13-7da629eb2cb1"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("09532631-d42f-4b8e-bd74-9fb8c8b94f3f"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("2158eec6-0a03-4921-b7f0-8fd6f11fa1cd"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("396f317e-6b80-489d-aa7c-a7e7a63e2cd1"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("44662994-9fd9-4835-92ac-41403a6d0c9d"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("4a67d79a-af3e-4252-bd6d-754664b8246d"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("5575b1b0-14fc-43a4-bc7c-e18d3ff492f0"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("614cc30c-d136-4350-b66b-9d0e67ca3d4d"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("62befa9f-8f33-4340-91af-5460b996fe0d"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("642ee04e-a9cf-4bdd-8133-ed5c04506d0d"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("6876a1bd-41b8-438d-9e28-d38d59493e74"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("6b658814-9de3-4a35-b75a-4e7578c4ae99"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("6dda5905-01de-4fcf-9fad-6d4151df79ad"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("96861ef9-0127-4357-8bdc-958e8bf25c1c"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("9a03bc77-4857-4afa-bc3d-340afacdf525"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("9b8d3ac5-d3b1-43f1-a78b-28838fd6de73"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("9cc16471-34d6-46d4-84f0-0bd955067cec"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("acfdf482-80ac-43e5-bc5c-93f9854fd7e6"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("b11391bd-84fd-4afc-ae7e-bfab9a75965f"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("b39ef71d-f523-4368-b267-6ff4a4b19f70"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("cade813a-ba72-4a30-9348-653a3d731dc4"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("cb59beb1-735e-4d0c-94e3-1bcd1d33e8ec"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("da014c12-c152-48f1-bcc2-68e96ed2a284"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("e02726a6-2517-4043-b3bd-d0a6324f8b0b"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("e2910069-5293-4740-b7ff-e34e69645db4"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("f3b33f0a-a46b-431b-b4f4-b66b83077049"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("fb9e2de2-5576-4ddb-8150-72cc0201bbb9"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("ff38b942-8e0e-446a-95b9-4ea765ffbe41"));

            migrationBuilder.AddColumn<Guid>(
                name: "DrugStoreId",
                table: "Drugs",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "Drugs",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "DrugStores",
                columns: new[] { "Id", "Address", "Contacts", "Name" },
                values: new object[,]
                {
                    { new Guid("071e109a-4678-4758-8b30-95003a673abb"), "Erdmanstad:838 Kling Way", "562.588.2644 x9055", "Pfannerstill - Greenholt" },
                    { new Guid("1ebdd60d-cf2e-4a70-ac83-82e1e05f8d8c"), "New Shanie:68944 Wolf Cliffs", "680.342.8316", "Schimmel Group" },
                    { new Guid("2cda5a5e-5ed4-4934-bf4e-a1c783856d4d"), "West Tyrel:524 Robel Curve", "1-445-345-4678", "Dickens, Fahey and Senger" },
                    { new Guid("2ded6f35-0c0d-4727-b76f-dbef03c16e8a"), "East Adityafort:8215 Shawn Estates", "(772) 996-1485", "Schaefer, Hayes and Blanda" },
                    { new Guid("3a015fe0-f354-4e6a-b836-799919905442"), "North Jaymemouth:97805 Strosin Mills", "1-974-545-8959", "Kozey - Marquardt" },
                    { new Guid("3b4b6c51-2e9d-43d2-87b0-1831deb6a4dc"), "New Jettie:145 Cale Burg", "1-274-554-8646 x955", "Gerhold, Mohr and Lemke" },
                    { new Guid("449d34a3-1e09-4619-b2fb-ea31d14816a2"), "Torphyberg:582 Haag Spurs", "1-629-639-0424 x1656", "Adams - Gleason" },
                    { new Guid("51fbd9ab-c30f-46e0-bd15-8bc999ed046b"), "Kuhicstad:44810 Luettgen Rapids", "492-919-0569 x87607", "Russel, Waelchi and White" },
                    { new Guid("6b2229ff-055b-4b3c-8433-c91fb9cee0d3"), "Lake Nathanael:7922 Keeling Cape", "(741) 354-3342", "Swift, Kihn and Cormier" },
                    { new Guid("6eefb17a-a179-45de-aeb9-64db91846d72"), "East Arnaldoberg:78030 Markus Parks", "556-322-6861", "Reinger LLC" },
                    { new Guid("744c9e2f-61df-4465-a051-ce5113da09a5"), "New Weldon:925 Libbie Square", "(216) 873-9270", "MacGyver - Rice" },
                    { new Guid("7a62649b-0a6f-47b5-a32a-ade59a80d476"), "Port Ardella:80064 Ezequiel Avenue", "461.241.7817", "Mosciski - VonRueden" },
                    { new Guid("85d716d3-6154-41a4-86a7-b4afd8cc7bd0"), "Moseberg:285 Devante Meadows", "(641) 266-0178 x49160", "Price - Oberbrunner" },
                    { new Guid("8785aab3-44d4-4128-84a4-acc02b01f7ec"), "Schimmelburgh:15502 Mertz Cliffs", "346-218-0273 x899", "Kuphal and Sons" },
                    { new Guid("8c57711d-5ecb-4e6f-8ec6-cb00513247d8"), "East Verda:309 Bo Islands", "680-793-4571 x39616", "Predovic Inc" },
                    { new Guid("8f3f0277-523d-4c14-a039-e521c1cf8e0e"), "Bergstromstad:68123 Marley Cape", "382-916-6585", "Schowalter - Hettinger" },
                    { new Guid("8fbf962c-b6d2-4505-a6e3-14bfd9b21269"), "Wisokyton:036 Kassulke Ramp", "926-604-8487", "Wintheiser LLC" },
                    { new Guid("9b3502bc-a2d6-4f8b-bef3-6484df106873"), "Simoniston:64660 Patrick Court", "435-618-2219 x487", "Yost, O'Connell and Daugherty" },
                    { new Guid("9c0d3cdd-7d31-4889-be3b-7ac4510e94cc"), "East Haven:5823 Mozell Island", "474-441-2702", "Lubowitz Inc" },
                    { new Guid("9fc79c51-4fa1-488b-840f-e758e4bf2c72"), "West Marianside:4768 Deja Hill", "1-651-314-6409 x69497", "Monahan - Pfannerstill" },
                    { new Guid("a5566167-d14b-4306-9693-2d94ef2b99e5"), "Port Marcel:6410 O'Hara Cape", "(587) 961-7684", "Schmidt LLC" },
                    { new Guid("b812cd4d-6921-419d-a4fd-05fb7820fef7"), "North Giovannaport:211 Cheyenne Track", "295.663.0289", "DuBuque - Wuckert" },
                    { new Guid("bdd77089-80be-4a82-9043-be9de05da68a"), "South Liam:622 Braxton Squares", "542-344-2600", "Kerluke - Roob" },
                    { new Guid("c29ff7b4-4f22-4445-b74e-4c1770fbed44"), "Markusville:5842 Fay Villages", "1-358-250-0656", "Blick, Zieme and Fahey" },
                    { new Guid("cf60ebb4-d9ee-4f28-8a75-1086303c2f07"), "North Rosemarieland:43569 Ismael Ports", "307.959.1967", "Bechtelar - Mann" },
                    { new Guid("cfbb6ac5-cb69-4404-8aab-7612d1b9a329"), "Bransontown:1007 Armstrong Divide", "(377) 391-1501", "Hagenes, Shanahan and Yost" },
                    { new Guid("d5d43ce7-b013-45eb-96ed-2672ac6f37ab"), "West Stacyton:2546 Swift Corners", "1-637-848-8608 x143", "Harris - Larkin" },
                    { new Guid("d6c46906-390d-41a6-8709-6f45a5487dd4"), "South Deborah:7511 Jolie Well", "(652) 386-6012 x1706", "Conn - Price" },
                    { new Guid("e7c169c6-87a0-4ae1-bb35-aa565ae8d650"), "West Gunner:66721 William Wells", "(630) 846-9693 x6050", "Morissette - Kreiger" },
                    { new Guid("fd09a144-512e-4256-b64c-ffe59bfe2f3f"), "West Jasen:811 Brekke Stravenue", "809-823-7954", "Schuppe - Labadie" }
                });

            migrationBuilder.InsertData(
                table: "Drugs",
                columns: new[] { "Id", "Description", "DrugStoreId", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("0c18faa8-8b79-44b7-b0e4-c454096c6469"), "Tramadol is a synthetic opioid used to treat moderate to severe pain.", new Guid("d5d43ce7-b013-45eb-96ed-2672ac6f37ab"), "Tramadol", "269.95" },
                    { new Guid("0fb09f09-24bc-4524-9cc8-6f279bd62e76"), "Venlafaxine is an antidepressant used to treat major depressive disorder and generalized anxiety disorder.", new Guid("d6c46906-390d-41a6-8709-6f45a5487dd4"), "Venlafaxine", "481.82" },
                    { new Guid("10303ac2-bc6a-4e8a-be56-b90be3293377"), "Hydrochlorothiazide is a diuretic used to treat high blood pressure and reduce fluid retention.", new Guid("e7c169c6-87a0-4ae1-bb35-aa565ae8d650"), "Hydrochlorothiazide", "494.16" },
                    { new Guid("20ef1956-3463-40f1-bd03-4e8cf9581c46"), "Prednisone is a corticosteroid medication used to reduce inflammation and suppress the immune system.", new Guid("3a015fe0-f354-4e6a-b836-799919905442"), "Prednisone", "581.01" },
                    { new Guid("3e49f107-5c2a-4daf-95d9-b7736dcaba74"), "Citalopram is an antidepressant medication used to treat depression and anxiety disorders.", new Guid("6b2229ff-055b-4b3c-8433-c91fb9cee0d3"), "Citalopram", "712.96" },
                    { new Guid("42327e89-f9bf-4396-a453-4817825dba65"), "Levothyroxine is used to treat an underactive thyroid gland (hypothyroidism) and maintain normal metabolism.", new Guid("6eefb17a-a179-45de-aeb9-64db91846d72"), "Levothyroxine", "950.43" },
                    { new Guid("42ade0fa-760a-4046-8586-cf246cca6e0e"), "Albuterol is a bronchodilator used to relieve symptoms of asthma and chronic obstructive pulmonary disease (COPD).", new Guid("8f3f0277-523d-4c14-a039-e521c1cf8e0e"), "Albuterol", "669.25" },
                    { new Guid("44b23e66-eb41-496b-af9c-8ec3daf33cc1"), "Olanzapine is an antipsychotic medication used to treat schizophrenia and bipolar disorder.", new Guid("6b2229ff-055b-4b3c-8433-c91fb9cee0d3"), "Olanzapine", "621.00" },
                    { new Guid("44bc5a24-746c-436f-a16c-d36a90a709b3"), "Diazepam is a benzodiazepine used to treat anxiety, muscle spasms, and seizures.", new Guid("3b4b6c51-2e9d-43d2-87b0-1831deb6a4dc"), "Diazepam", "190.88" },
                    { new Guid("44cdee61-7f5f-4e10-9adf-1c7d35e425f9"), "Paracetamol is a common pain reliever and fever reducer.", new Guid("7a62649b-0a6f-47b5-a32a-ade59a80d476"), "Paracetamol", "328.59" },
                    { new Guid("59d8a16c-b7e1-4f05-a23e-9f08d21c4721"), "Fluoxetine is an antidepressant medication used to treat depression, obsessive-compulsive disorder (OCD), and panic disorder.", new Guid("3a015fe0-f354-4e6a-b836-799919905442"), "Fluoxetine", "670.91" },
                    { new Guid("792d771f-7704-4f3b-8790-a8b8d5fe07a7"), "Loratadine is an antihistamine used to relieve allergy symptoms such as sneezing, runny nose, and itching.", new Guid("8785aab3-44d4-4128-84a4-acc02b01f7ec"), "Loratadine", "518.36" },
                    { new Guid("834a69ec-1a13-4594-9f13-42209aee30f8"), "Metoprolol is a beta-blocker used to treat high blood pressure and prevent heart attacks and migraines.", new Guid("d6c46906-390d-41a6-8709-6f45a5487dd4"), "Metoprolol", "164.58" },
                    { new Guid("927755a9-1f27-47c4-8a3a-e1175e61d8ed"), "Warfarin is an anticoagulant (blood thinner) used to prevent blood clots and strokes.", new Guid("a5566167-d14b-4306-9693-2d94ef2b99e5"), "Warfarin", "302.45" },
                    { new Guid("9abfd28f-7395-47d6-b04d-19d9d8d6e033"), "Lisinopril is an angiotensin-converting enzyme (ACE) inhibitor used to lower high blood pressure and treat heart failure.", new Guid("51fbd9ab-c30f-46e0-bd15-8bc999ed046b"), "Lisinopril", "545.97" },
                    { new Guid("9b7746bf-a3fa-45ef-b943-3c7862ad3199"), "Aspirin is commonly used as a pain reliever and anti-inflammatory agent, as well as for its blood-thinning properties.", new Guid("3b4b6c51-2e9d-43d2-87b0-1831deb6a4dc"), "Aspirin", "988.29" },
                    { new Guid("a1e49c08-4c6b-432b-a496-c87f08a9a60d"), "Ibuprofen is a nonsteroidal anti-inflammatory drug (NSAID) used to relieve pain, reduce inflammation, and lower fever.", new Guid("8c57711d-5ecb-4e6f-8ec6-cb00513247d8"), "Ibuprofen", "917.49" },
                    { new Guid("af507cc4-0e18-443e-ba1d-b0b9239de2ff"), "Amoxicillin is an antibiotic used to treat bacterial infections, including respiratory and urinary tract infections.", new Guid("8c57711d-5ecb-4e6f-8ec6-cb00513247d8"), "Amoxicillin", "203.61" },
                    { new Guid("bb225f3b-c1e1-488f-adaa-5b4c9b094fb0"), "Simvastatin is a medication that lowers cholesterol levels in the blood, reducing the risk of heart disease.", new Guid("9b3502bc-a2d6-4f8b-bef3-6484df106873"), "Simvastatin", "917.74" },
                    { new Guid("c955e599-282d-4933-9075-963fdd75b4c1"), "Metformin is a drug used to treat type 2 diabetes by lowering blood sugar levels.", new Guid("744c9e2f-61df-4465-a051-ce5113da09a5"), "Metformin", "581.32" },
                    { new Guid("ccb148c7-3c69-4b4b-8a27-1f4a47c33dae"), "Amlodipine is a calcium channel blocker used to treat high blood pressure and angina (chest pain).", new Guid("d6c46906-390d-41a6-8709-6f45a5487dd4"), "Amlodipine", "68.44" },
                    { new Guid("deeb0a07-5778-42d6-aab0-603889559248"), "Hydrocodone is an opioid pain medication used to relieve moderate to severe pain.", new Guid("2ded6f35-0c0d-4727-b76f-dbef03c16e8a"), "Hydrocodone", "740.03" },
                    { new Guid("df0986ad-c65e-4e6c-8333-527bf9f903d8"), "Ranitidine is an H2 blocker used to reduce stomach acid and relieve conditions like heartburn and ulcers.", new Guid("9fc79c51-4fa1-488b-840f-e758e4bf2c72"), "Ranitidine", "361.36" },
                    { new Guid("e066007c-a76c-4cc0-b911-51429d7a66ee"), "Losartan is an angiotensin II receptor blocker (ARB) used to treat high blood pressure and protect the kidneys in diabetes.", new Guid("6b2229ff-055b-4b3c-8433-c91fb9cee0d3"), "Losartan", "625.76" },
                    { new Guid("e31d1c9f-c216-4d24-ae2e-e681800933eb"), "Atorvastatin is a medication used to lower cholesterol levels and reduce the risk of cardiovascular diseases.", new Guid("2ded6f35-0c0d-4727-b76f-dbef03c16e8a"), "Atorvastatin", "326.47" },
                    { new Guid("eb8a72f3-8bcb-4f43-bed4-320ce980e91b"), "Ciprofloxacin is an antibiotic used to treat a variety of bacterial infections, including urinary tract and skin infections.", new Guid("071e109a-4678-4758-8b30-95003a673abb"), "Ciprofloxacin", "680.50" },
                    { new Guid("f9c4dc90-5417-49ee-a4a1-7d5602956b9f"), "Omeprazole is used to reduce stomach acid production and treat conditions like stomach and esophagus ulcers and acid reflux.", new Guid("85d716d3-6154-41a4-86a7-b4afd8cc7bd0"), "Omeprazole", "939.28" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drugs_DrugStoreId",
                table: "Drugs",
                column: "DrugStoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Drugs_DrugStores_DrugStoreId",
                table: "Drugs",
                column: "DrugStoreId",
                principalTable: "DrugStores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
