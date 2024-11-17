using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InatelTeste.Infrastructure.migrations
{
    public partial class addPropertiesInUniversityTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CountryCode",
                table: "University",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StateProvince",
                table: "University",
                type: "longtext",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryCode",
                table: "University");

            migrationBuilder.DropColumn(
                name: "StateProvince",
                table: "University");
        }
    }
}
