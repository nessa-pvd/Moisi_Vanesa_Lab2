using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moisi_Vanesa_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class FinalAddressFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Member",
                newName: "Address");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Member",
                newName: "Address");
        }
    }
}
