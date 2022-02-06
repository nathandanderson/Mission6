using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Entries",
                columns: table => new
                {
                    TaskID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TaskName = table.Column<string>(nullable: true),
                    DueDate = table.Column<string>(nullable: true),
                    Quadrant = table.Column<int>(nullable: false),
                    Completed = table.Column<bool>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entries", x => x.TaskID);
                    table.ForeignKey(
                        name: "FK_Entries_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 1, "Home" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 2, "School" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 3, "Work" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 4, "Church" });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "TaskID", "CategoryID", "Completed", "DueDate", "Quadrant", "TaskName" },
                values: new object[] { 2, 1, false, "02/12/22", 3, "Laundry" });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "TaskID", "CategoryID", "Completed", "DueDate", "Quadrant", "TaskName" },
                values: new object[] { 3, 1, false, "None", 4, "Respond to emails" });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "TaskID", "CategoryID", "Completed", "DueDate", "Quadrant", "TaskName" },
                values: new object[] { 1, 2, false, "02/09/22", 1, "Mission6 Assignment" });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "TaskID", "CategoryID", "Completed", "DueDate", "Quadrant", "TaskName" },
                values: new object[] { 4, 4, false, "None", 2, "Relationship Building" });

            migrationBuilder.CreateIndex(
                name: "IX_Entries_CategoryID",
                table: "Entries",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entries");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
