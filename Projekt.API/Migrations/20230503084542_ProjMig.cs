using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt.API.Migrations
{
    public partial class ProjMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Universities");

            migrationBuilder.DropColumn(
                name: "GPA",
                table: "Universities");

            migrationBuilder.RenameColumn(
                name: "UniversityNumber",
                table: "Universities",
                newName: "UniversityName");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Universities",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "DOB",
                table: "Universities",
                newName: "UniversityDateCreated");

            migrationBuilder.AddColumn<string>(
                name: "Dean",
                table: "Faculties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dean",
                table: "Faculties");

            migrationBuilder.RenameColumn(
                name: "UniversityName",
                table: "Universities",
                newName: "UniversityNumber");

            migrationBuilder.RenameColumn(
                name: "UniversityDateCreated",
                table: "Universities",
                newName: "DOB");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Universities",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Universities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "GPA",
                table: "Universities",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
