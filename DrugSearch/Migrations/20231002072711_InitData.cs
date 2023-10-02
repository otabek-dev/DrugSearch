using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrugSearch.Migrations
{
    /// <inheritdoc />
    public partial class InitData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DrugStores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Contacts = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugStores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drugs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<string>(type: "text", nullable: false),
                    DrugStoreId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drugs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drugs_DrugStores_DrugStoreId",
                        column: x => x.DrugStoreId,
                        principalTable: "DrugStores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drugs");

            migrationBuilder.DropTable(
                name: "DrugStores");
        }
    }
}
