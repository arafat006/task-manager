using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiMasterTemplate.Domain.Migrations
{
    public partial class Addedtasktrackerseed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TaskTracker",
                columns: new[] { "Id", "CreatedBy", "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(258), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(308), "Iusto qui velit ut quaerat vitae sint reiciendis ut neque.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(345), "Explicabo aut." },
                    { 2L, 1L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(428), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(430), "Animi molestias magni quia maxime.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(432), "Odio." },
                    { 3L, 1L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(478), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(479), "Modi culpa et qui consequatur incidunt.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(480), "Nam eligendi." },
                    { 4L, 2L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(558), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(560), "Ullam et labore ut voluptates reiciendis.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(561), "Culpa." },
                    { 5L, 2L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(617), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(618), "Enim sed magni magnam cumque cupiditate omnis dolores blanditiis ut.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(620), "Libero ipsum." },
                    { 6L, 2L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(659), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(660), "Et atque dolorem eligendi veritatis.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(661), "Sit repudiandae." },
                    { 7L, 3L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(705), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(706), "Aut ut consequatur ab sed consectetur nihil et.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(707), "Omnis." },
                    { 8L, 3L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(760), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(761), "Ipsa fugiat consequatur atque et saepe qui quia accusamus.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(762), "Qui alias." },
                    { 9L, 3L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(848), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(849), "Incidunt dolorem quae ex fugiat est ducimus saepe quas nisi.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(851), "Temporibus soluta." },
                    { 10L, 4L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(896), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(897), "Voluptatem totam numquam repudiandae rerum ut consectetur.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(898), "Delectus eveniet." },
                    { 11L, 4L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(942), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(943), "Error velit amet et dolor non earum doloribus.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(945), "Voluptatem." },
                    { 12L, 4L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(986), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(987), "Maiores vero repellendus iste et praesentium sed.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(988), "Iure." },
                    { 13L, 5L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1129), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1130), "Quibusdam dolore eveniet sint iste laudantium.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1131), "Consequuntur." },
                    { 14L, 5L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1166), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1167), "Quis architecto aut repudiandae sit.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1201), "Alias." },
                    { 15L, 5L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1240), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1241), "Suscipit minima odio facere expedita nisi.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1243), "Nemo." },
                    { 16L, 6L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1276), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1277), "Consequatur neque ex eveniet qui.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1278), "Ut et." },
                    { 17L, 6L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1325), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1326), "Et et quis sit quaerat at voluptatem qui qui.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1328), "Molestias possimus." },
                    { 18L, 6L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1377), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1378), "Omnis fuga aut unde sunt fugit reiciendis molestias similique est.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1379), "Aut." },
                    { 19L, 7L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1411), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1412), "Alias praesentium quae perspiciatis quia.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1413), "Facilis." },
                    { 20L, 7L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1516), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1517), "Sequi dolor omnis qui pariatur tempora perspiciatis sunt.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1518), "Eum deserunt." },
                    { 21L, 7L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1561), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1562), "Illum dolorum est consequatur possimus et sit.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1563), "Non." },
                    { 22L, 8L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1602), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1603), "Amet maiores dignissimos nesciunt veniam.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1604), "Veritatis." },
                    { 23L, 8L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1688), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1689), "Consequuntur illo est veritatis voluptatibus molestias quibusdam eius debitis maxime.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1690), "Est." },
                    { 24L, 8L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1730), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1731), "Et porro alias rerum natus quisquam et.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1732), "Aspernatur." },
                    { 25L, 9L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1780), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1838), "Et earum id quia quis fugit id non cupiditate sit.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1840), "Voluptates sed." },
                    { 26L, 9L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1880), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1881), "Quaerat enim rem possimus totam.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1882), "Laborum enim." },
                    { 27L, 9L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1916), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1917), "Illum aut aspernatur distinctio deleniti.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1918), "Ut error." },
                    { 28L, 10L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1948), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1949), "Tenetur sapiente animi libero alias.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1950), "Velit." },
                    { 29L, 10L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1995), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1996), "Voluptatem aut quo quia dolorem a natus magnam itaque tenetur.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1997), "In." },
                    { 30L, 10L, new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(2032), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(2033), "Delectus ab ut maiores officia.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(2034), "Quis aperiam." }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 418, DateTimeKind.Utc).AddTicks(4748), "JermaineJacobson_Mraz@yahoo.com", "Jermaine Jacobson", "MfffsByeh1b83jcv7ZmvEOq3zR0A2c5vFRsFR_yH305_uvofiacdaX8qKBESVFfa5US6Zz_uAoHfxLUo56zU_WgpIp4FSaCpR2Xveg4j02J6C1xFB0pNL9unskBV8ZjS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 418, DateTimeKind.Utc).AddTicks(5510), "JusticeBrekke14@yahoo.com", "Justice Brekke", "Laskl6xl8lygdj2BhZfBUeg1TOUIWfZsDRSYpiJJ7qBzn7gHVPfvFPThjnXC_MMvTpgT0hIq4vK0N3YxmUg_pFdsnb3TWAan44mDGtBeozeeQeYVSx_WeQc6FbH_Pz2G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 418, DateTimeKind.Utc).AddTicks(6102), "SallyLesch_Witting87@hotmail.com", "Sally Lesch", "E55ttcQqS63rygYOowXuPAfiUALHY9UO2Pj8oTvy97wQxoQS3DavJKaL_18ez1Ix72O7NaOCsb1YAGcsDnYaI4r23lJjMN4jYTuT0T62DK_ScEQQhxHwOCrD99ORF1r9" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 418, DateTimeKind.Utc).AddTicks(6658), "JacyntheStracke_Runte58@yahoo.com", "Jacynthe Stracke", "6KksoYzaark5zkS7zRtILm2jFB3r9b5k27n5vrhvlibawfQNTpKcny98bK4Kgf4a3Hsku3QL7yVwESehiuyAB6tlKkmxX5xf5WGymx4yXVx2ZfxkyOyW8o8wb_sUAa5S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 418, DateTimeKind.Utc).AddTicks(7174), "VallieKovacek.Friesen@yahoo.com", "Vallie Kovacek", "tHw3kGj4U9iHedfEyJQjCP25elsiUhWIzSpFTEVyKkpXt5Z2ryuXHW1Voc6NjhzVccrA66nn_bep3ZrWGoXNOib2zwDapxRUimj2Ff8rdGFDutZ0Rr30t0LZcQiIvWen" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 418, DateTimeKind.Utc).AddTicks(7696), "ChristTurner_Yundt68@gmail.com", "Christ Turner", "hipr8SU0NHvHk5n98jE6_efJ4DENw5va3ovVrPTScc0u90LBPkVEqsSLHmk5ddIck1XjvIEMlrSSZC_E2uIK3cJL7T5H4LyZlabbYSndzGEbw8MbPItxO82N8GijAo_i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 418, DateTimeKind.Utc).AddTicks(8278), "EstrellaHermann_Gerlach@hotmail.com", "Estrella Hermann", "NgvWuKBUmkc99dIVUPOKBuyMzrMilm5YoBkaLTDxOUkY5ItcfeWwSMPFbmkrzkhPdEEQuQfTSjQ_fKy2vqIX60MGEJ2IV87IGKMkRoYmOwl_hDNjan_WP9uHx3Mb52HX" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 418, DateTimeKind.Utc).AddTicks(8810), "KaraHegmann.Macejkovic10@gmail.com", "Kara Hegmann", "Q15koOiLB75gefbpvizARwL9KcaIK8apxYF5zUOMll9xyi6JqTJuFx_jo5VhdNSocpjcBcuDIAPGlMFltK2x1Ui7Ta_fbI9fusxHFiawnOpnf88gLfG2PH8An3whyDV0" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 418, DateTimeKind.Utc).AddTicks(9359), "LeonelHand.Littel4@yahoo.com", "Leonel Hand", "BqYOX75FSQgXcWknxcvVRowDsVjsPD6WRxMJNfwD4tmNMmmcYD4b2Lfk3nD4uAeOlba_va4p5sUf4DL_Suv5tA0_bRFX6V3CYD9vJhHjFlBWaSIlPyJF5HBshm8yZ160" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 418, DateTimeKind.Utc).AddTicks(9985), "EttieSchmidt.Kshlerin@yahoo.com", "Ettie Schmidt", "sA9Zfka0edqavutySCUrltT0c1b6Niu2gNppzJnpKQwbZGxILNTW_ZJaFM1xcdF5V79FvKSTd_aH9yIw_GQYx0HmvAN9l82yGRfXf5piUCJIWYRjEDrjDXe0bZK9NY9r" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 16, 13, 740, DateTimeKind.Utc).AddTicks(4604), "KelsieTurner14@hotmail.com", "Kelsie Turner", "odd07TV66wbdS2x9MiNYxAyVdihGF8GRdgaMdof7kCWHtgSDy7HttU8fqcuthCoj_v3gjj4De2zltuOnVy7CheI_DNSnb0uVhHRgLbnCr9mw0wn_g6jXt8eRi1FgE93p" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 16, 13, 740, DateTimeKind.Utc).AddTicks(6202), "OmaDurgan.Klein24@hotmail.com", "Oma Durgan", "N_QKg_i0V_YXpKq2ci1RsBTFNxZT9NGpPjA6KQlmge6JeOIx96UOjNisG4fvXKqCIMJBHFZCBdhpRjgtCJC8tWhBzvOromI1ZxwXq8gEtR3a0YuL4K7ZMn1h4RPRtErd" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 16, 13, 740, DateTimeKind.Utc).AddTicks(7229), "DominicCrooks.Yundt@hotmail.com", "Dominic Crooks", "U5wchkdFSk4uHUMvspsBzvb7_awHOYkotwSgCrHqZ3jMhrjAcYUDKIRZh95zGzj0Cepi9u8dA4PKW8i8vVnSRJFfdug6vaTxdQJAnGb4kLxNyoGI5f2BPFEZAjoYcw5N" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 16, 13, 740, DateTimeKind.Utc).AddTicks(8341), "KatrineErnser49@hotmail.com", "Katrine Ernser", "ClxKudvUCH_G6hNwZtkLjDbA9_4taUwYEL3iFtCAYA7fVftKOeyKUyOk3YdmxFSvv5fnF3fTWzcBveh9Sz6CSQoAGtOZNQMXnMkD6WbTeDiO7O1VMjyZblUjEni_vq6R" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 16, 13, 740, DateTimeKind.Utc).AddTicks(9576), "ChynaHowell_Stamm62@yahoo.com", "Chyna Howell", "xzKqrnyWcxHQYlpiNgSrs8WJJOg_1m6b7XiImNV1PyBmNcf9cr2cbK4jk02sg8qw8CDLVX35a0SCeGnNwsAgKqVGIMJbwT0aXySfyjlweq5P48taIrD41p__NiKrXHrS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 16, 13, 741, DateTimeKind.Utc).AddTicks(860), "WillaLynch20@hotmail.com", "Willa Lynch", "X9fvmJx4Gl3HWPl7Sd9E6tc97fwz1pG32sA202Ef0JN3bhkMuaqPnekJy7DqugnCKJHjb99E47cEaP3AvvGRA7onSjxKlkqymLMto0bh7oy2QFKaCIxIHDVscs8F8LB3" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 16, 13, 741, DateTimeKind.Utc).AddTicks(1944), "RettaFeeney_Runte77@hotmail.com", "Retta Feeney", "eu2z5pApg5CVRViM0mR5UejvcxA7pxnGDOT1zWAQ1f3iXrkIlIhz7oobw2T7auyuIhzIXutH15nDTwlKRScad1zXXnr2WCR2MrsR2bg2gGmtpupkSungBM6jHdIUINlW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 16, 13, 741, DateTimeKind.Utc).AddTicks(3155), "RodolfoMetz_Bogisich82@hotmail.com", "Rodolfo Metz", "kfrS602tTxKkue4f9gVJ1d1HJc9tMBjgxQ9Y8wRkTFkEnmVmjgGF33pxGPY9yGENpUknigA8iQMR90DAO3buVieGQ9Y9y6jPP_DBFXrotLz9bHXOfqf7ysDv0wqGnRQf" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 16, 13, 741, DateTimeKind.Utc).AddTicks(4362), "FlorineTurcotte.Schaefer21@yahoo.com", "Florine Turcotte", "beyawg7dwZpFqmOwiBpOqfdXpP1KELBmW6_9UY8KjNZLhGAm9EmxzYmxanzApV7ov7eCj7rfIxmpZzulU4aUq9dJOmblqETbnlN6E4R3FWfvH9Avcu_gthNU5EhlOeWj" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 16, 13, 741, DateTimeKind.Utc).AddTicks(5491), "RogerSpinka.McCullough75@gmail.com", "Roger Spinka", "nPAnhlINMg7P61hwRw6YQR_80gSDsDuXfdLFEI35Q4YnDzcLV7qYQuXbADX6j27oAyRSOQPjAeN_QDrMh0tb8R6dNKC5MIUK5HkNHb0o_KPGYYppHX2gng3hC62YyXTy" });
        }
    }
}
