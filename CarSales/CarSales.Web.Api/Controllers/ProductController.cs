using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarSales.Web.Api.Controllers
{
    public class ProductController : ApiController
    {
        public string Get()
        {
            return "Default of Product Controller.";
        }

        [ActionName("GetByBrand")]
        public string Get(string name)
        {
            return "Filtered with name";
        }
    }
}
