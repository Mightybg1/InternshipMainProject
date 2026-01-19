using PlantCare.Models;       
using Microsoft.EntityFrameworkCore;


namespace PlantCare.Models
{
    public class Plant
    {
        public int PlantId { get; set; }
        public string PlaneName { get; set; }
        public string ScientificName { get; set; }
        public string PlantType { get; set; }

        public double PlantHeight { get; set; }
        public double ExpectedGrowthPerMonth { get; set; }
        public int LifeSpan { get; set; }

        public int WaterPerDays { get; set; }
        public double WaterAmmouth { get; set; }
        public string LightRequirement { get; set; }
        public bool DirectSunlight { get; set; }

        public string SoilType { get; set; }
        public double SoilPh { get; set; }
        public double PotSize { get; set; }

        public double PreferableTemperature { get; set; }
        public string CommonDiseases { get; set; }
        public string CommonPests { get; set; }

        public bool IsHarmfulToHumans { get; set; }
        public bool IsHarmfulToAnimals { get; set; }

        public string NativeRegion { get; set; }
    }
}
