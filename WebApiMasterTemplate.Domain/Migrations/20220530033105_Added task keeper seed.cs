using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiMasterTemplate.Domain.Migrations
{
    public partial class Addedtaskkeeperseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "Id", "Deadline", "State", "TaskTrackerId", "Title" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 1L, "Exercitationem." },
                    { 2L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 1L, "Omnis inventore." },
                    { 3L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 1L, "Illum." },
                    { 4L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 1L, "Voluptate quos." },
                    { 5L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 1L, "Blanditiis id." },
                    { 6L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 2L, "Beatae ea." },
                    { 7L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 2L, "Assumenda voluptatum." },
                    { 8L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 2L, "Saepe." },
                    { 9L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 2L, "Libero facere." },
                    { 10L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 2L, "Doloremque odio." },
                    { 11L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 3L, "Asperiores." },
                    { 12L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 3L, "Et quo." },
                    { 13L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 3L, "Consequatur facilis." },
                    { 14L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 3L, "Sed." },
                    { 15L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 3L, "Aut." },
                    { 16L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 4L, "Natus." },
                    { 17L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 4L, "Dolor." },
                    { 18L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 4L, "Cumque." },
                    { 19L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 4L, "Harum ducimus." },
                    { 20L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 4L, "Placeat sunt." },
                    { 21L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 5L, "Sapiente." },
                    { 22L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 5L, "Aut dolor." },
                    { 23L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 5L, "Voluptatem." },
                    { 24L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 5L, "Debitis." },
                    { 25L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 5L, "Voluptas." },
                    { 26L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 6L, "Voluptatem." },
                    { 27L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 6L, "Nulla." },
                    { 28L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 6L, "Rem quo." },
                    { 29L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 6L, "Ut." },
                    { 30L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 6L, "Illum eius." },
                    { 31L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 7L, "Distinctio voluptatum." },
                    { 32L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 7L, "Nisi." },
                    { 33L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 7L, "Culpa iste." },
                    { 34L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 7L, "Saepe." },
                    { 35L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 7L, "Qui." },
                    { 36L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 8L, "Odit." },
                    { 37L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 8L, "Nesciunt in." },
                    { 38L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 8L, "Quo." },
                    { 39L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 8L, "Eius a." },
                    { 40L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 8L, "Quia quam." },
                    { 41L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 9L, "Aut." },
                    { 42L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 9L, "Quae." }
                });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "Id", "Deadline", "State", "TaskTrackerId", "Title" },
                values: new object[,]
                {
                    { 43L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 9L, "Odio." },
                    { 44L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 9L, "Sed." },
                    { 45L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 9L, "Quis." },
                    { 46L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 10L, "Quisquam ratione." },
                    { 47L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 10L, "Aut." },
                    { 48L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 10L, "Modi." },
                    { 49L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 10L, "Cupiditate." },
                    { 50L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 10L, "Ut quod." },
                    { 51L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 11L, "Iure rerum." },
                    { 52L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 11L, "Rerum est." },
                    { 53L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 11L, "Aspernatur." },
                    { 54L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 11L, "Explicabo." },
                    { 55L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 11L, "Facere." },
                    { 56L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 12L, "Nostrum." },
                    { 57L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 12L, "Facere." },
                    { 58L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 12L, "Debitis." },
                    { 59L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 12L, "Dolores." },
                    { 60L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 12L, "Est laboriosam." },
                    { 61L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 13L, "Aperiam." },
                    { 62L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 13L, "Quia odio." },
                    { 63L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 13L, "Repellendus quaerat." },
                    { 64L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 13L, "Perspiciatis." },
                    { 65L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 13L, "Voluptatum incidunt." },
                    { 66L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 14L, "Et." },
                    { 67L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 14L, "Et doloremque." },
                    { 68L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 14L, "Sed." },
                    { 69L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 14L, "Quisquam." },
                    { 70L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 14L, "Ratione." },
                    { 71L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 15L, "Ut qui." },
                    { 72L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 15L, "Ea quisquam." },
                    { 73L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 15L, "Laudantium est." },
                    { 74L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 15L, "Unde." },
                    { 75L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 15L, "Occaecati." },
                    { 76L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 16L, "Provident quis." },
                    { 77L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 16L, "Voluptatum voluptatem." },
                    { 78L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 16L, "Nobis." },
                    { 79L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 16L, "Pariatur." },
                    { 80L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 16L, "Aliquam." },
                    { 81L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 17L, "Reiciendis quis." },
                    { 82L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 17L, "Sed." },
                    { 83L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 17L, "Quia." },
                    { 84L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 17L, "Rerum perspiciatis." }
                });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "Id", "Deadline", "State", "TaskTrackerId", "Title" },
                values: new object[,]
                {
                    { 85L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 17L, "Saepe." },
                    { 86L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 18L, "Sapiente." },
                    { 87L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 18L, "Aut." },
                    { 88L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 18L, "Nemo." },
                    { 89L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 18L, "Quis tenetur." },
                    { 90L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 18L, "Ex." },
                    { 91L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 19L, "Et optio." },
                    { 92L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 19L, "Aut ipsa." },
                    { 93L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 19L, "Est voluptatum." },
                    { 94L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 19L, "Dolorum." },
                    { 95L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 19L, "Cupiditate." },
                    { 96L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 20L, "Fugiat id." },
                    { 97L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 20L, "Blanditiis ut." },
                    { 98L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 20L, "Minima." },
                    { 99L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 20L, "Veritatis eius." },
                    { 100L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 20L, "Eos impedit." },
                    { 101L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 21L, "Voluptas dolorem." },
                    { 102L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 21L, "Ipsam." },
                    { 103L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 21L, "Sint." },
                    { 104L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 21L, "Facere." },
                    { 105L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 21L, "Blanditiis perspiciatis." },
                    { 106L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 22L, "Reprehenderit dolorum." },
                    { 107L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 22L, "Ducimus." },
                    { 108L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 22L, "Ut." },
                    { 109L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 22L, "Sint id." },
                    { 110L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 22L, "Commodi." },
                    { 111L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 23L, "Perferendis ut." },
                    { 112L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 23L, "Non." },
                    { 113L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 23L, "Qui." },
                    { 114L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 23L, "Est tempore." },
                    { 115L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 23L, "Quam." },
                    { 116L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 24L, "Est deleniti." },
                    { 117L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 24L, "Voluptas." },
                    { 118L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 24L, "Inventore et." },
                    { 119L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 24L, "Tempora." },
                    { 120L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 24L, "Qui." },
                    { 121L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 25L, "Aliquid." },
                    { 122L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 25L, "Molestiae." },
                    { 123L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 25L, "Ea." },
                    { 124L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 25L, "Doloribus." },
                    { 125L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 25L, "Reiciendis." },
                    { 126L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 26L, "Eum nemo." }
                });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "Id", "Deadline", "State", "TaskTrackerId", "Title" },
                values: new object[,]
                {
                    { 127L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 26L, "Ut sint." },
                    { 128L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 26L, "Aut." },
                    { 129L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 26L, "Pariatur." },
                    { 130L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 26L, "Id." },
                    { 131L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 27L, "Provident." },
                    { 132L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 27L, "Aut ut." },
                    { 133L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 27L, "Ut." },
                    { 134L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 27L, "Aut sed." },
                    { 135L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 27L, "Molestias." },
                    { 136L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 28L, "Et." },
                    { 137L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 28L, "Omnis dolorem." },
                    { 138L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 28L, "Magnam illo." },
                    { 139L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 28L, "Optio dignissimos." },
                    { 140L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 28L, "Eum." },
                    { 141L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 3, 29L, "Iure repellat." },
                    { 142L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 29L, "Numquam." },
                    { 143L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 29L, "Velit voluptatem." },
                    { 144L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 29L, "Veniam voluptas." },
                    { 145L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 2, 29L, "Odit." },
                    { 146L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 30L, "Ullam omnis." },
                    { 147L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 30L, "Et dolor." },
                    { 148L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 4, 30L, "Perferendis aut." },
                    { 149L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 30L, "Quas." },
                    { 150L, new DateTime(2022, 6, 3, 3, 31, 4, 866, DateTimeKind.Utc).AddTicks(1445), 1, 30L, "Officia." }
                });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(397), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(445), "Rerum et qui minus aspernatur minima sit nihil.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(488), "Rerum eos." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(593), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(596), "Fugit possimus voluptas inventore laudantium quo repellendus optio.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(598), "Et." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(648), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(650), "Et necessitatibus et aut voluptatum et consequatur aliquam.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(651), "Aliquid." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(780), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(782), "Tenetur facilis repudiandae odit tenetur quod vel.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(783), "Dolorum quia." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(827), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(828), "Culpa qui corrupti voluptatem ad et.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(829), "Asperiores ex." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(872), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(873), "Exercitationem suscipit labore sed veniam facere saepe aut.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(874), "Eum." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(918), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(920), "Tenetur qui inventore minus enim deserunt nostrum itaque provident dolor.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(921), "Doloribus." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(971), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(972), "Dolore sunt dicta nemo non inventore quam beatae rerum.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(973), "Est." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1067), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1068), "Ipsum ut consectetur occaecati dolor omnis commodi officiis cupiditate quidem.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1069), "Voluptas repellat." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1112), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1113), "Consequatur asperiores qui est vel deleniti minus fugit.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1114), "Qui." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1159), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1160), "Distinctio voluptatibus adipisci recusandae accusamus ut eligendi voluptatem voluptas.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1161), "Qui." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1200), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1201), "Et molestias quis doloremque est aliquid.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1202), "Ea tempore." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1241), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1242), "Sit qui quia rerum a molestias laborum.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1243), "Voluptatem et." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1327), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1328), "Repellendus est expedita non maiores sint maiores provident beatae.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1330), "Illo fugit." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1365), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1366), "Magni sunt itaque ut hic.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1367), "Esse voluptatibus." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1401), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1402), "Assumenda occaecati enim repellendus et.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1403), "Tempora error." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1440), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1442), "Aperiam doloremque laboriosam pariatur et nam reprehenderit.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1443), "Corrupti." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1480), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1481), "Excepturi quia facere rerum vitae ipsam consequatur vero.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1482), "Harum." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1518), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1519), "Nam earum recusandae nihil quis aperiam.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1520), "Sed nisi." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1560), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1561), "Est fuga quia voluptatem voluptas possimus nihil.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1562), "Quis unde." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1596), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1597), "Necessitatibus consectetur repellendus amet ea.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1598), "Voluptate quia." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1701), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1702), "Nam accusantium qui molestias aut voluptate est nulla veniam.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1704), "Omnis." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1739), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1740), "Sunt omnis autem vero et sed.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1741), "Veniam." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1785), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1786), "Alias maxime omnis tempore eius consequuntur rerum nesciunt qui.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1787), "Occaecati porro." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1828), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1829), "Repudiandae nemo praesentium autem molestiae harum id et.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1830), "Quis voluptas." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1873), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1874), "Doloremque nemo dolorum ipsa et sit dolores velit tenetur consequuntur.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1875), "Eos blanditiis." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1949), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1951), "Quod porro aut dolorem saepe ut temporibus repellat consequatur.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(1952), "Et." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(2001), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(2002), "Consequatur qui nemo debitis enim molestiae omnis voluptates pariatur aut.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(2003), "Omnis eos." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(2043), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(2044), "Neque minus hic odio voluptatem itaque et hic.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(2045), "A perferendis." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(2088), new DateTime(2022, 6, 6, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(2089), "Explicabo voluptas ea est quod non ea nesciunt sint eos.", new DateTime(2022, 5, 30, 3, 31, 4, 860, DateTimeKind.Utc).AddTicks(2091), "Non consequuntur." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 851, DateTimeKind.Utc).AddTicks(2841), "ColtonRunolfsson_Schaefer58@yahoo.com", "Colton Runolfsson", "HHT6ZBh71OnufroWa1pYZEAvE1Yp731zVR2GMYFSHMCPAo1SLxJlwe9e9FeXel_KOaLG2I7EoYmS9FWQMUy3_mC5UXH1MonqBjtCuudnQm38rDrkaf6v5kLU26A82DIn" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 851, DateTimeKind.Utc).AddTicks(3493), "LambertKohler_Hand41@gmail.com", "Lambert Kohler", "qzDGqPrwTpaUMwKq9C_cK92gUFfqbAftqdi8j9EWoLs8TzQCUVP_7rx3c4hirGfWJTEKswJrWGFFHTDQgEpSzKeVZZVRgTUfyfnhvC9oiDZ3oKUg0gA4fs_6SWctY2Z_" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 851, DateTimeKind.Utc).AddTicks(4019), "CamdenHodkiewicz99@gmail.com", "Camden Hodkiewicz", "kts2X267JC7t7_mZ1LGRIqvEhMV0JaevnivDPL3r5YjBnuy0fiXlUdEs0DXyvEQbIPOuWwME2iT7KeBk0kaOBQffdfoWfubFbejeqS3O1lOOKg86biufTRndTzSFIrVv" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 851, DateTimeKind.Utc).AddTicks(4582), "EvanGrady.Mertz35@yahoo.com", "Evan Grady", "_W5hGqiA4gYavBBoD_e0qI246aJ_yy_3IOwoVYmqJ7eeepUA81FJWlEInWtQaKJWl3KNNJwzotmE476xHjqdKflvH6lTvLKR3sNeShy2wSw2RSDSl7BMLPm0r22wB2d6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 851, DateTimeKind.Utc).AddTicks(5116), "TyrellWintheiser61@hotmail.com", "Tyrell Wintheiser", "jBZtbNgk7OABX6dmdQrO0xAGKsSUGFSWzoSPQlKm4lx7y8MXYcmnJpGR3Ykv3ZMOsVInSt2gUTzqwtZcLBTXG_Hu3jDWtApaaDfZvA6j4BsNQvjCE4KsrXn1gnA8N8UM" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 851, DateTimeKind.Utc).AddTicks(5643), "KatlynnSenger_Bernhard@yahoo.com", "Katlynn Senger", "4J2NiciuIJxycZD9mZdShBhEajYDPVEUa1zbL1axzHdkwWPlE3LX1mO9YBvdcmcNyFmo49sPpxEyHy3iqy4E2clwtct06eF9SRT7ifhmsmrAMBzJolBD3UiHIW_3X9iK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 851, DateTimeKind.Utc).AddTicks(6219), "GinoGraham39@hotmail.com", "Gino Graham", "eqgPABSk7lEm6SM9LP_ZJuPoAg1AvwT8A82jSmHiDPZuOSQMuySFlYonyD248bcR3wloUqUqie0Itg7DEbWUNoLo4nDc1fdQmEAQTRHw91kNH9YBUXoCx9JaWQd0zJxs" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 851, DateTimeKind.Utc).AddTicks(6847), "MonserratSauer_Ritchie13@hotmail.com", "Monserrat Sauer", "QhhqzoXaSwTkZZlOdUWv35LN8qlrWvHgH0PcJMh8M535H2ZTx4DeUOFd5IDKbtMbGNJK_21EBmvH1Lm5ZSnqNDzi9frjhamlS_mquwCY_5l4ZoRQLJXSeZgQiFHfxFZe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 851, DateTimeKind.Utc).AddTicks(7378), "ConnieEffertz.Brown@gmail.com", "Connie Effertz", "eCcz0CmCUwTgPEkXthSrkNOb1nNN8O1R7KqAyeHh0NiLKSTnWsxj4VQdVuU6JQC9TbCPcEYdnHp59Hjoq_3K1IH0V57VbvuAxWv4sJpZvPVqXnkGCPoRqbMC6QsnsCXD" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 31, 4, 851, DateTimeKind.Utc).AddTicks(7897), "WillardGutkowski.Kshlerin3@hotmail.com", "Willard Gutkowski", "fkxrsA9AXurQHbqlONFbAoHfdwQt7fn8Q9PUfJ8JuE54jamnEs5g_ngStT7RdqcbnZkg55gF7uEpG3hM8wdavDfC9VXCl4vuzo6qWv9tF82DM3oe5ebJaYUEcmrRHt6b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 150L);

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(258), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(308), "Iusto qui velit ut quaerat vitae sint reiciendis ut neque.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(345), "Explicabo aut." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(428), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(430), "Animi molestias magni quia maxime.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(432), "Odio." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(478), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(479), "Modi culpa et qui consequatur incidunt.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(480), "Nam eligendi." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(558), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(560), "Ullam et labore ut voluptates reiciendis.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(561), "Culpa." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(617), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(618), "Enim sed magni magnam cumque cupiditate omnis dolores blanditiis ut.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(620), "Libero ipsum." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(659), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(660), "Et atque dolorem eligendi veritatis.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(661), "Sit repudiandae." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(705), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(706), "Aut ut consequatur ab sed consectetur nihil et.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(707), "Omnis." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(760), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(761), "Ipsa fugiat consequatur atque et saepe qui quia accusamus.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(762), "Qui alias." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(848), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(849), "Incidunt dolorem quae ex fugiat est ducimus saepe quas nisi.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(851), "Temporibus soluta." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(896), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(897), "Voluptatem totam numquam repudiandae rerum ut consectetur.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(898), "Delectus eveniet." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(942), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(943), "Error velit amet et dolor non earum doloribus.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(945), "Voluptatem." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(986), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(987), "Maiores vero repellendus iste et praesentium sed.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(988), "Iure." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1129), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1130), "Quibusdam dolore eveniet sint iste laudantium.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1131), "Consequuntur." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1166), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1167), "Quis architecto aut repudiandae sit.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1201), "Alias." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1240), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1241), "Suscipit minima odio facere expedita nisi.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1243), "Nemo." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1276), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1277), "Consequatur neque ex eveniet qui.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1278), "Ut et." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1325), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1326), "Et et quis sit quaerat at voluptatem qui qui.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1328), "Molestias possimus." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1377), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1378), "Omnis fuga aut unde sunt fugit reiciendis molestias similique est.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1379), "Aut." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1411), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1412), "Alias praesentium quae perspiciatis quia.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1413), "Facilis." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1516), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1517), "Sequi dolor omnis qui pariatur tempora perspiciatis sunt.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1518), "Eum deserunt." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1561), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1562), "Illum dolorum est consequatur possimus et sit.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1563), "Non." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1602), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1603), "Amet maiores dignissimos nesciunt veniam.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1604), "Veritatis." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1688), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1689), "Consequuntur illo est veritatis voluptatibus molestias quibusdam eius debitis maxime.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1690), "Est." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1730), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1731), "Et porro alias rerum natus quisquam et.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1732), "Aspernatur." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1780), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1838), "Et earum id quia quis fugit id non cupiditate sit.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1840), "Voluptates sed." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1880), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1881), "Quaerat enim rem possimus totam.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1882), "Laborum enim." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1916), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1917), "Illum aut aspernatur distinctio deleniti.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1918), "Ut error." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1948), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1949), "Tenetur sapiente animi libero alias.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1950), "Velit." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1995), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1996), "Voluptatem aut quo quia dolorem a natus magnam itaque tenetur.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(1997), "In." });

            migrationBuilder.UpdateData(
                table: "TaskTracker",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreationDate", "Deadline", "Description", "LastUpdatedDate", "Title" },
                values: new object[] { new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(2032), new DateTime(2022, 6, 6, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(2033), "Delectus ab ut maiores officia.", new DateTime(2022, 5, 30, 3, 17, 51, 424, DateTimeKind.Utc).AddTicks(2034), "Quis aperiam." });

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
    }
}
