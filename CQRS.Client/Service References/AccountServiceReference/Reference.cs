﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18213
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using CQRS.Client.AccountServiceReference;

namespace CQRS.Client.AccountServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AccountServiceReference.IAccountService")]
    public interface IAccountService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetAccountBalance", ReplyAction="http://tempuri.org/IAccountService/GetAccountBalanceResponse")]
        decimal GetAccountBalance(string account);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/Transfer", ReplyAction="http://tempuri.org/IAccountService/TransferResponse")]
        void Transfer(string fromAccount, string toAccount, decimal amount);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAccountServiceChannel : CQRS.Client.AccountServiceReference.IAccountService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AccountServiceClient : System.ServiceModel.ClientBase<CQRS.Client.AccountServiceReference.IAccountService>, CQRS.Client.AccountServiceReference.IAccountService {

        public AccountServiceClient() {
        }
        
        public AccountServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AccountServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public decimal GetAccountBalance(string account) {
            return base.Channel.GetAccountBalance(account);
        }
        
        public void Transfer(string fromAccount, string toAccount, decimal amount) {
            base.Channel.Transfer(fromAccount, toAccount, amount);
        }
    }
}
