using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibraryDb.Migrations
{
    /// <inheritdoc />
    public partial class v21 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Transaction Id",
                table: "BankTransactions",
                newName: "transaction_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "transaction_id",
                table: "BankTransactions",
                newName: "Transaction Id");
        }
    }
}
