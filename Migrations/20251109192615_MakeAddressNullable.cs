using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moisi_Vanesa_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class MakeAddressNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
        name: "Address",
        table: "Member",
        type: "nvarchar(max)",
        nullable: true, // <-- Coloana devine opțională (NULL)
        oldClrType: typeof(string),
        oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
        name: "Address",
        table: "Member",
        type: "nvarchar(max)",
        nullable: false, // <-- Coloana devine obligatorie (NOT NULL)
        defaultValue: "", // Adaugă o valoare implicită, deși ar trebui să fie setată anterior
        oldClrType: typeof(string),
        oldType: "nvarchar(max)",
        oldNullable: true);
        }
    }
}
