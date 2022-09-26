using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiMasterTemplate.Domain.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(128)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskTracker",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTracker", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskTracker_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskTrackerId = table.Column<long>(type: "bigint", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Task_TaskTracker_TaskTrackerId",
                        column: x => x.TaskTrackerId,
                        principalTable: "TaskTracker",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedDate", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 5, 28, 19, 10, 44, 5, DateTimeKind.Utc).AddTicks(744), "JerroldBeahan79@gmail.com", "Jerrold Beahan", "_hpGqGPhzktEtjKHmIOHezxWJ1aTfHU3VjACspwC6okiTo_hU9b7RZb1x3GulFbTZqKtr4tS6EUaJ_IpdCM8M4Xo7xljSLvSyqtnXt7hUenBX7L4bR4kzngF_E9WlVBP" },
                    { 2L, new DateTime(2022, 5, 28, 19, 10, 44, 5, DateTimeKind.Utc).AddTicks(1375), "CarolinaOrn9@hotmail.com", "Carolina Orn", "Pa_iYCzV14uv111OPwxFTrfg1T7p5jvERDVe8TNlAvntmAd_8CTaPlnMX_Dyn4Fn5QkcWckEfpa8UB1gNd4XAIHa9XMGEUgfAr4jkV4KqiSY_mYZGNNJWKOURgnTH2Et" },
                    { 3L, new DateTime(2022, 5, 28, 19, 10, 44, 6, DateTimeKind.Utc).AddTicks(5571), "MoniqueOConnell66@yahoo.com", "Monique O'Connell", "jv3v6_ZKZumKESDHl3K7xHxATonW6o9okL2KRfPY6QTe67XmIqLj7pR406J7q83ptUsvl_YXFMnXypiVA0mpIxjDALQz7O6dgODLg1rOBieGpRXkonx54NmbUt8UqKCq" },
                    { 4L, new DateTime(2022, 5, 28, 19, 10, 44, 6, DateTimeKind.Utc).AddTicks(6593), "BrantOndricka94@gmail.com", "Brant Ondricka", "uvwr5J5IadaQmpTWIVZ1EB5b7aimjrkJaGtTP9xBUqUFSItehoRuaHrrp2TpDHAHgtPpLZrS9imVr8IP1wLx09DcnvZ0sWWmYNLTeIn3_5LnUkBBIBeHB20u89AwDxoO" },
                    { 5L, new DateTime(2022, 5, 28, 19, 10, 44, 6, DateTimeKind.Utc).AddTicks(7587), "WymanCummings26@gmail.com", "Wyman Cummings", "EYkgabakx7cljiRbaMw3B0SP6UazIIWmlsrIZhqTk_FdS4wwZakmzYmqHb8nVcL3jrtaf0MjkaiQqIBq60mEA4axuymrNeyKEItB7JurkNpxohDRikCW1ntP1MZsB3WD" },
                    { 6L, new DateTime(2022, 5, 28, 19, 10, 44, 6, DateTimeKind.Utc).AddTicks(8641), "VenaPouros_Gerhold@hotmail.com", "Vena Pouros", "F_nNec2j8Z5hIRTmEfm2SmGatgo1FztMu2Bp14TVJydo8kWxIoGkohGzpLGGBRbEnBliHgkBCwS_g3xtY6Lvg3xoaNcO9pGYHMisXuabJ3AWPNUrqWMbUKL23uHxD2yu" },
                    { 7L, new DateTime(2022, 5, 28, 19, 10, 44, 6, DateTimeKind.Utc).AddTicks(9639), "EstaBerge85@hotmail.com", "Esta Berge", "PRpDLSfA4OH0JhDXZJcndDyefEcY1M4hDWy_HhGqZntoa04Ylz9YMGj9wp8dzDslFN8CVHojQlWkOX6YuP8gIbIJY0XAsa9NkjzDDxZI6Lx4iHIymQtWV4c1UiA8Ebve" },
                    { 8L, new DateTime(2022, 5, 28, 19, 10, 44, 7, DateTimeKind.Utc).AddTicks(615), "CarmelaMorissette83@yahoo.com", "Carmela Morissette", "5Z1teqibHPhjMknFkFdMYtyaALdYO4fZCHr1P_b8gdWVG6QKcfgB5cIG2a655zVRq_vBUJ6Pq7F3XnauDAZja95keqeVzTh3CQFciFn9X8GgAPhuPrW0MYKEkb0n574G" },
                    { 9L, new DateTime(2022, 5, 28, 19, 10, 44, 7, DateTimeKind.Utc).AddTicks(1660), "StephenLynch95@yahoo.com", "Stephen Lynch", "cRVUSzX7SdAdYaWRXIQJzDlk43GCN_l89fReZvS2dBih8JCyGl8VjGZa3UsunWBLItTJCCM9BYXz4RPXyqleNxEyRtS2G44SefcQIofn0U4V4LSra6hj7HFre9Tg6FQY" },
                    { 10L, new DateTime(2022, 5, 28, 19, 10, 44, 7, DateTimeKind.Utc).AddTicks(2747), "VioletteKozey.Johnson95@gmail.com", "Violette Kozey", "1w1JWbSFD9OYg0NQ37qg7czGM6Hqz29PiMBrRS92FXQW80n6JychHKlcPCsST9gJ3cM3veIST26yXzXRhh4FBGXj6c1FbUfrU_tO43neE9SeeY38H7Lgl5f43Lqd5VU_" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Task_TaskTrackerId",
                table: "Task",
                column: "TaskTrackerId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskTracker_CreatedBy",
                table: "TaskTracker",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Task");

            migrationBuilder.DropTable(
                name: "TaskTracker");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
