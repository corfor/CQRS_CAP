﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CQRS.Client.QueryServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="QueryServiceReference.IAccountQueryService")]
    public interface IAccountQueryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountQueryService/GetAccountBalance", ReplyAction="http://tempuri.org/IAccountQueryService/GetAccountBalanceResponse")]
        decimal GetAccountBalance(string account);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAccountQueryServiceChannel : CQRS.Client.QueryServiceReference.IAccountQueryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AccountQueryServiceClient : System.ServiceModel.ClientBase<CQRS.Client.QueryServiceReference.IAccountQueryService>, CQRS.Client.QueryServiceReference.IAccountQueryService {
        
        public AccountQueryServiceClient() {
        }
        
        public AccountQueryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AccountQueryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountQueryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountQueryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public decimal GetAccountBalance(string account) {
            return base.Channel.GetAccountBalance(account);
        }
    }
}
