﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloServiceTCPClient.SayHelloService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SayHelloService.ISayHelloService")]
    public interface ISayHelloService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISayHelloService/SayHello", ReplyAction="http://tempuri.org/ISayHelloService/SayHelloResponse")]
        string SayHello(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISayHelloService/SayHello", ReplyAction="http://tempuri.org/ISayHelloService/SayHelloResponse")]
        System.Threading.Tasks.Task<string> SayHelloAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISayHelloServiceChannel : HelloServiceTCPClient.SayHelloService.ISayHelloService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SayHelloServiceClient : System.ServiceModel.ClientBase<HelloServiceTCPClient.SayHelloService.ISayHelloService>, HelloServiceTCPClient.SayHelloService.ISayHelloService {
        
        public SayHelloServiceClient() {
        }
        
        public SayHelloServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SayHelloServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SayHelloServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SayHelloServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string SayHello(string name) {
            return base.Channel.SayHello(name);
        }
        
        public System.Threading.Tasks.Task<string> SayHelloAsync(string name) {
            return base.Channel.SayHelloAsync(name);
        }
    }
}
