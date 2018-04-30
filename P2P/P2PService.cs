using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Security.Cryptography;

namespace P2P
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class P2PService : IP2PService
    {
        private MainWindow hostReference;
        private string username;
        private RSAParameters publicKey;

        public P2PService(MainWindow hostReference, string username, RSAParameters pKey)
        {
            this.hostReference = hostReference;
            this.username = username;
            this.publicKey = pKey;
        }

        public string GetName()
        {
            return username;
        }

        public RSAParameters GetKey()
        {
            return publicKey;
        }

        public void SendMessage(byte[] message, string from)
        {
            hostReference.DisplayMessage(message, from);
        }
    }
}
