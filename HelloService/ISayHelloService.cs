﻿using System.ServiceModel;

namespace HelloService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHelloService" in both code and config file together.
    [ServiceContract]
    public interface ISayHelloService
    {
        [OperationContract]
        string SayHello(string name);
    }
}
