using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tasksBD.Migrations
{
    /// <inheritdoc />
    public partial class onelot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_MemberId",
                table: "Tasks",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Members_MemberId",
                table: "Tasks",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Members_MemberId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_MemberId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Tasks");

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.Id);
                });
        }
    }
}
