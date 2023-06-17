using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProjectPWI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PetList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PetName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PetType = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PetBreed = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetList", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PetList");
        }
    }
}
