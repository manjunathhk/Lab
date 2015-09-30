using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using CarSales.Dal;
using CarSales.Dal.Interfaces;
using CarSales.Models;
using CarSales.Web.Api.Models;

namespace CarSales.Web.Api.Controllers
{
    //[Route("api/car/")]
    //[RoutePrefix("car")]
    public class CarController1 : ApiController
    {
        private readonly IList<Car> cars;
        public CarController1()
        {
            ICarData carData = new CarData();
            cars = carData.GetAllCars();
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
                where car.Manufacturer.Equals(brand, StringComparison.InvariantCultureIgnoreCase)
                select car).ToList();

            return carList;
        }

        [Route("api/car/{brand}/{name}")]
        //[Route("{brand}/{model}")]
        public IList<Car> Get(string brand, string name)
        {
            IList<Car> carList = (from car in cars
                                  where car.Manufacturer.Equals(brand, StringComparison.InvariantCultureIgnoreCase) && car.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase)
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
