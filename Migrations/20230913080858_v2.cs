using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace students.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhoneStudent");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_StudentId",
                table: "Phones",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_Students_StudentId",
                table: "Phones",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phones_Students_StudentId",
                table: "Phones");

            migrationBuilder.DropIndex(
                name: "IX_Phones_StudentId",
                table: "Phones");

            migrationBuilder.CreateTable(
                name: "PhoneStudent",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneStudent", x => new { x.StudentId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_PhoneStudent_Phones_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Phones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneStudent_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhoneStudent_StudentsId",
                table: "PhoneStudent",
                column: "StudentsId");
        }
    }
}
