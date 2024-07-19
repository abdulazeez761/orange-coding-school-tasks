using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolAppMvcsCore.Migrations
{
    /// <inheritdoc />
    public partial class editingtsad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentTaskText",
                table: "Tasks",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentTaskText",
                table: "Tasks");
        }
    }
}
