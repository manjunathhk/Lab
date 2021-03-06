﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Learning.WcfService.Consumer.UserServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserServiceReference.IUserService")]
    public interface IUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/SaveUser", ReplyAction="http://tempuri.org/IUserService/SaveUserResponse")]
        string SaveUser(Learning.WcfService.Models.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/SaveUser", ReplyAction="http://tempuri.org/IUserService/SaveUserResponse")]
        System.Threading.Tasks.Task<string> SaveUserAsync(Learning.WcfService.Models.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUserInformation", ReplyAction="http://tempuri.org/IUserService/GetUserInformationResponse")]
        Learning.WcfService.Models.User GetUserInformation();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUserInformation", ReplyAction="http://tempuri.org/IUserService/GetUserInformationResponse")]
        System.Threading.Tasks.Task<Learning.WcfService.Models.User> GetUserInformationAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceChannel : Learning.WcfService.Consumer.UserServiceReference.IUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<Learning.WcfService.Consumer.UserServiceReference.IUserService>, Learning.WcfService.Consumer.UserServiceReference.IUserService {
        
        public UserServiceClient() {
        }
        
        public UserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string SaveUser(Learning.WcfService.Models.User user) {
            return base.Channel.SaveUser(user);
        }
        
        public System.Threading.Tasks.Task<string> SaveUserAsync(Learning.WcfService.Models.User user) {
            return base.Channel.SaveUserAsync(user);
        }
        
        public Learning.WcfService.Models.User GetUserInformation() {
            return base.Channel.GetUserInformation();
        }
        
        public System.Threading.Tasks.Task<Learning.WcfService.Models.User> GetUserInformationAsync() {
            return base.Channel.GetUserInformationAsync();
        }
    }
}
