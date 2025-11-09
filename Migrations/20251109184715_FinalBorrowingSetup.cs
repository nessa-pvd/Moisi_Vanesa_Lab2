using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moisi_Vanesa_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class FinalBorrowingSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Borrowing");

            migrationBuilder.DropTable(
                name: "Member");
        }
    }
}
