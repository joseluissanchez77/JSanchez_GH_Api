using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JSanchez_GH_Api.Migrations
{
    /// <inheritdoc />
    public partial class AddMigrationPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identification = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Second_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    First_Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Second_Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place_Of_Birth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_Of_Birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marital_Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "CreatedDate", "Date_Of_Birth", "First_Last_Name", "First_Name", "Identification", "Marital_Status", "Nationality", "Photo", "Place_Of_Birth", "Second_Last_Name", "Second_Name", "Sexo", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 27, 19, 59, 48, 768, DateTimeKind.Local).AddTicks(6071), new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), "Sanchez", "Jose", "0931147284", "Soltero", "Ecuatoriana", "", "Guayas", "Baque", "Luis", "Masculino", new DateTime(2023, 6, 27, 19, 59, 48, 768, DateTimeKind.Local).AddTicks(6072) },
                    { 2, new DateTime(2023, 6, 27, 19, 59, 48, 768, DateTimeKind.Local).AddTicks(6075), new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), "Ososrio", "Karen", "0931147597", "Soltero", "Ecuatoriana", "", "Guayas", "Jimenes", "Anais", "Femenimo", new DateTime(2023, 6, 27, 19, 59, 48, 768, DateTimeKind.Local).AddTicks(6076) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
