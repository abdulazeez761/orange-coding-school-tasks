using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mvc_first_task.Migrations
{
    /// <inheritdoc />
    public partial class secondmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feadbacks_Employees_ManagerID",
                table: "Feadbacks");

            migrationBuilder.RenameColumn(
                name: "ManagerID",
                table: "Feadbacks",
                newName: "SentToID");

            migrationBuilder.RenameIndex(
                name: "IX_Feadbacks_ManagerID",
                table: "Feadbacks",
                newName: "IX_Feadbacks_SentToID");

            migrationBuilder.AddForeignKey(
                name: "FK_Feadbacks_Employees_SentToID",
                table: "Feadbacks",
                column: "SentToID",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feadbacks_Employees_SentToID",
                table: "Feadbacks");

            migrationBuilder.RenameColumn(
                name: "SentToID",
                table: "Feadbacks",
                newName: "ManagerID");

            migrationBuilder.RenameIndex(
                name: "IX_Feadbacks_SentToID",
                table: "Feadbacks",
                newName: "IX_Feadbacks_ManagerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Feadbacks_Employees_ManagerID",
                table: "Feadbacks",
                column: "ManagerID",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
