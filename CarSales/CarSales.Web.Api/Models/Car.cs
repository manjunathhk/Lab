namespace CarSales.Web.Api.Models
{
    public class Car
    {
        public string Brand { get; set; }
        
        public string Model { get; set; }

        public string Variant { get; set; }

        public decimal Torque { get; set; }

        public decimal MaxSpeed { get; set; }
    }
}