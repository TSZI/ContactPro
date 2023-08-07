using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactPro.Migrations
{
    public partial class ChangeStatesToState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "States",
                table: "Contacts",
                newName: "State");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "State",
                table: "Contacts",
                newName: "States");
        }
    }
}
