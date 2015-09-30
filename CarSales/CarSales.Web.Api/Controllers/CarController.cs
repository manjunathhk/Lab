using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using CarSales.Web.Api.Models;

namespace CarSales.Web.Api.Controllers
{
    //[Route("api/car/")]
    //[RoutePrefix("car")]
    public class CarController : ApiController
    {
        private readonly IList<Car> cars;
        public CarController()
        {
            cars = new List<Car>
            {
                new Car {Brand = "Hyundai", Model = "i10", MaxSpeed = 160, Torque = 10, Variant = "Era"},
                new Car {Brand = "Hyundai", Model = "i10", MaxSpeed = 160, Torque = 10, Variant = "Magna"},
                new Car {Brand = "Hyundai", Model = "i10", MaxSpeed = 160, Torque = 10, Variant = "Sportz"},
                new Car {Brand = "Hyundai", Model = "i10", MaxSpeed = 160, Torque = 10, Variant = "Asta"},
                new Car {Brand = "Hyundai", Model = "i20", MaxSpeed = 160, Torque = 10, Variant = "Era"},
                new Car {Brand = "Hyundai", Model = "i20", MaxSpeed = 160, Torque = 10, Variant = "Magna"},
                new Car {Brand = "Hyundai", Model = "i20", MaxSpeed = 160, Torque = 10, Variant = "Sportz"},
                new Car {Brand = "Hyundai", Model = "i20", MaxSpeed = 160, Torque = 10, Variant = "Asta"},
                new Car {Brand = "Maruthi", Model = "Ertiga", MaxSpeed = 140, Torque = 8, Variant = "LXi"},
                new Car {Brand = "Maruthi", Model = "Ertiga", MaxSpeed = 140, Torque = 8, Variant = "VXi"},
                new Car {Brand = "Maruthi", Model = "Ertiga", MaxSpeed = 140, Torque = 8, Variant = "ZXi"}
            };
        }
        // GET: api/Car
        public IList<Car> Get()
        {
            return cars;
        }

        // GET: api/Car/5
        [Route("api/car/{brand}")]
        //[Route("{brand}")]
        public IList<Car> Get(string brand)
        {
            IList<Car> carList = (from car in cars
                where car.Brand.Equals(brand, StringComparison.InvariantCultureIgnoreCase)
                select car).ToList();

            return carList;
        }

        [Route("api/car/{brand}/{model}")]
        //[Route("{brand}/{model}")]
        public IList<Car> Get(string brand, string model)
        {
            IList<Car> carList = (from car in cars
                                  where car.Brand.Equals(brand, StringComparison.InvariantCultureIgnoreCase) && car.Model.Equals(model, StringComparison.InvariantCultureIgnoreCase)
                                  select car).ToList();

            return carList;
        }

        // POST: api/Car
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Car/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Car/5
        public void Delete(int id)
        {
        }
    }
}
