using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlantCare.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plant",
                columns: table => new
                {
                    PlantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaneName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScientificName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlantType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlantHeight = table.Column<double>(type: "float", nullable: false),
                    ExpectedGrowthPerMonth = table.Column<double>(type: "float", nullable: false),
                    LifeSpan = table.Column<int>(type: "int", nullable: false),
                    WaterPerDays = table.Column<int>(type: "int", nullable: false),
                    WaterAmmouth = table.Column<double>(type: "float", nullable: false),
                    LightRequirement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DirectSunlight = table.Column<bool>(type: "bit", nullable: false),
                    SoilType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoilPh = table.Column<double>(type: "float", nullable: false),
                    PotSize = table.Column<double>(type: "float", nullable: false),
                    PreferableTemperature = table.Column<double>(type: "float", nullable: false),
                    CommonDiseases = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommonPests = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsHarmfulToHumans = table.Column<bool>(type: "bit", nullable: false),
                    IsHarmfulToAnimals = table.Column<bool>(type: "bit", nullable: false),
                    NativeRegion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plant", x => x.PlantId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plant");
        }
    }
}
