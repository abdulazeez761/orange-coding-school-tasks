using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolAppMvcsCore.Migrations
{
    /// <inheritdoc />
    public partial class photofield : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "photoPath",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "photoPath",
                table: "Students");
        }
    }
}
