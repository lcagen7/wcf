﻿//namespace HelloServiceClient.SayHelloService
//{


//    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
//    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "SayHelloService.ISayHelloService")]
//    public interface ISayHelloService
//    {

//        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ISayHelloService/SayHello", ReplyAction = "http://tempuri.org/ISayHelloService/SayHelloResponse")]
//        string SayHello(string name);

//        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ISayHelloService/SayHello", ReplyAction = "http://tempuri.org/ISayHelloService/SayHelloResponse")]
//        System.Threading.Tasks.Task<string> SayHelloAsync(string name);
//    }

//    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
//    public interface ISayHelloServiceChannel : HelloServiceClient.SayHelloService.ISayHelloService, System.ServiceModel.IClientChannel
//    {
//    }

//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
//    public partial class SayHelloServiceClient : System.ServiceModel.ClientBase<HelloServiceClient.SayHelloService.ISayHelloService>, HelloServiceClient.SayHelloService.ISayHelloService
//    {

//        public SayHelloServiceClient()
//        {
//        }

//        public SayHelloServiceClient(string endpointConfigurationName) :
//                base(endpointConfigurationName)
//        {
//        }

//        public SayHelloServiceClient(string endpointConfigurationName, string remoteAddress) :
//                base(endpointConfigurationName, remoteAddress)
//        {
//        }

//        public SayHelloServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
//                base(endpointConfigurationName, remoteAddress)
//        {
//        }

//        public SayHelloServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
//                base(binding, remoteAddress)
//        {
//        }

//        public string SayHello(string name)
//        {
//            return base.Channel.SayHello(name);
//        }

//        public System.Threading.Tasks.Task<string> SayHelloAsync(string name)
//        {
//            return base.Channel.SayHelloAsync(name);
//        }
//    }
//}
