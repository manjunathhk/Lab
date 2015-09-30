using System;
using System.Collections.Generic;
using System.Linq;
using CarSales.Dal.Interfaces;
using CarSales.Models;

namespace CarSales.Dal
{
    public class CarData : ICarData
    {
        private readonly IList<Car> cars;
        public CarData()
        {
            cars = new List<Car>
            {
                new Car {Id = 1, Manufacturer = "Hyundai", Name = "i10", MaxSpeed = 160, Torque = 10, Variant = "Era"},
                new Car {Id = 2, Manufacturer = "Hyundai", Name = "i10", MaxSpeed = 160, Torque = 10, Variant = "Magna"},
                new Car {Id = 3, Manufacturer = "Hyundai", Name = "i10", MaxSpeed = 160, Torque = 10, Variant = "Sportz"},
                new Car {Id = 4, Manufacturer = "Hyundai", Name = "i10", MaxSpeed = 160, Torque = 10, Variant = "Asta"},
                new Car {Id = 5, Manufacturer = "Hyundai", Name = "i20", MaxSpeed = 160, Torque = 10, Variant = "Era"},
                new Car {Id = 6, Manufacturer = "Hyundai", Name = "i20", MaxSpeed = 160, Torque = 10, Variant = "Magna"},
                new Car {Id = 7, Manufacturer = "Hyundai", Name = "i20", MaxSpeed = 160, Torque = 10, Variant = "Sportz"},
                new Car {Id = 8, Manufacturer = "Hyundai", Name = "i20", MaxSpeed = 160, Torque = 10, Variant = "Asta"},
                new Car {Id = 9, Manufacturer = "Maruthi", Name = "Ertiga", MaxSpeed = 140, Torque = 8, Variant = "LXi"},
                new Car {Id = 10, Manufacturer = "Maruthi", Name = "Ertiga", MaxSpeed = 140, Torque = 8, Variant = "VXi"},
                new Car {Id = 11, Manufacturer = "Maruthi", Name = "Ertiga", MaxSpeed = 140, Torque = 8, Variant = "ZXi"}
            };
        }
        public IList<Car> GetAll()
        {
            return cars;
        }

        public IList<Car> GetByManufacturer(string manufacturer)
        {
            IList<Car> carList = cars.Where(car => car.Manufacturer.Equals(manufacturer, StringComparison.InvariantCultureIgnoreCase)).ToList();

            return carList;
        }

        public Car GetById(decimal id)
        {
            Car car = (cars.FirstOrDefault(carById => carById.Id == id));
            return car;
        }

        public decimal Add(Car car)
        {
            if (car != null)
            {
                car.Id = cars.Count + 1;
                cars.Add(car);
                return car.Id;
            }
            return -1;
        }

        public bool Update(Car car)
        {
            if (car != null && car.Id > 0)
            {
                return true;
            }
            return false;
        }

        public bool RemoveById(decimal id)
        {
            cars.Remove(GetById(id));
            return true;
        }
    }
}
