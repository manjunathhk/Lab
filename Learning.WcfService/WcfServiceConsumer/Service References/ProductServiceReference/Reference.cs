﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Learning.WcfService.Consumer.ProductServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductServiceReference.IProductService")]
    public interface IProductService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/Save", ReplyAction="http://tempuri.org/IProductService/SaveResponse")]
        bool Save(Learning.WcfService.Models.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/Save", ReplyAction="http://tempuri.org/IProductService/SaveResponse")]
        System.Threading.Tasks.Task<bool> SaveAsync(Learning.WcfService.Models.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetAll", ReplyAction="http://tempuri.org/IProductService/GetAllResponse")]
        Learning.WcfService.Models.Product GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetAll", ReplyAction="http://tempuri.org/IProductService/GetAllResponse")]
        System.Threading.Tasks.Task<Learning.WcfService.Models.Product> GetAllAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductServiceChannel : Learning.WcfService.Consumer.ProductServiceReference.IProductService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductServiceClient : System.ServiceModel.ClientBase<Learning.WcfService.Consumer.ProductServiceReference.IProductService>, Learning.WcfService.Consumer.ProductServiceReference.IProductService {
        
        public ProductServiceClient() {
        }
        
        public ProductServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Save(Learning.WcfService.Models.Product product) {
            return base.Channel.Save(product);
        }
        
        public System.Threading.Tasks.Task<bool> SaveAsync(Learning.WcfService.Models.Product product) {
            return base.Channel.SaveAsync(product);
        }
        
        public Learning.WcfService.Models.Product GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<Learning.WcfService.Models.Product> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
    }
}
