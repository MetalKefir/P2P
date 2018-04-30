using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Security.Cryptography;

namespace P2P
{
    [ServiceContract]
    public interface IP2PService
    {
        [OperationContract]
        string GetName();

        [OperationContract]
        RSAParameters GetKey();

        [OperationContract(IsOneWay = true)]
        void SendMessage(byte[] message, string from);
    }
}
