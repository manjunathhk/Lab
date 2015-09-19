using System.ServiceModel;
using Learning.WcfService.Models;

namespace Learning.WcfService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserService" in both code and config file together.
    [ServiceContract]
    public interface IUserService
    {

        [OperationContract]
        string SaveUser(User user);

        [OperationContract]
        User GetUserInformation();
    }


    
}
