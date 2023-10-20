using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibraryDb.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Transaction To",
                table: "BankTransactions",
                newName: "transaction_to");

            migrationBuilder.RenameColumn(
                name: "Transaction From",
                table: "BankTransactions",
                newName: "transaction_from");

            migrationBuilder.RenameColumn(
                name: "Transaction Date",
                table: "BankTransactions",
                newName: "transaction_date");

            migrationBuilder.RenameColumn(
                name: "Transaction Amount",
                table: "BankTransactions",
                newName: "transaction_amount");

            migrationBuilder.AlterColumn<decimal>(
                name: "transaction_amount",
                table: "BankTransactions",
                type: "decimal(7,2)",
                precision: 7,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "transaction_to",
                table: "BankTransactions",
                newName: "Transaction To");

            migrationBuilder.RenameColumn(
                name: "transaction_from",
                table: "BankTransactions",
                newName: "Transaction From");

            migrationBuilder.RenameColumn(
                name: "transaction_date",
                table: "BankTransactions",
                newName: "Transaction Date");

            migrationBuilder.RenameColumn(
                name: "transaction_amount",
                table: "BankTransactions",
                newName: "Transaction Amount");

            migrationBuilder.AlterColumn<decimal>(
                name: "Transaction Amount",
                table: "BankTransactions",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(7,2)",
                oldPrecision: 7,
                oldScale: 2);
        }
    }
}
