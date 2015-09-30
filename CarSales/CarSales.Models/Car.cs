namespace CarSales.Models
{
    public class Car : Product
    {
        public string Manufacturer { get; set; }

        public string FuelType { get; set; }

        public string Variant { get; set; }

        public decimal Torque { get; set; }

        public decimal MaxSpeed { get; set; }
    }
}
