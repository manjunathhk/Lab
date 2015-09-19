using System.ServiceModel;
using Learning.WcfService.Models;

namespace Learning.WcfService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductService.svc or ProductService.svc.cs at the Solution Explorer and start debugging.
    public class ProductService : IProductService
    {
        public bool Save(Product product)
        {
            return true;
        }

        public Product GetAll()
        {
            throw new FaultException("There was a problem in the service.");
            // return new Product {Id = 1, Name = "Visual Studio 2015"};
        }
    }
}
