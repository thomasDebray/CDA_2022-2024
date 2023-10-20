using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationCereals.Migrations
{
    /// <inheritdoc />
    public partial class cerealsv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Protein",
                table: "tbl_cereals",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Protein",
                table: "tbl_cereals");
        }
    }
}
