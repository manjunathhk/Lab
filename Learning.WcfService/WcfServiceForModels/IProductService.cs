using System.ServiceModel;
using Learning.WcfService.Models;

namespace Learning.WcfService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductService" in both code and config file together.
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        bool Save(Product product);

        [OperationContract]
        Product GetAll();
    }
}
