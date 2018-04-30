using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.PeerToPeer;
using System.Security.Cryptography;

namespace P2P
{
    class PeerEntry
    {
        public PeerName PeerName { get; set; }
        public IP2PService ServiceProxy { get; set; }
        public string DisplayString { get; set; }
        public bool ButtonsEnabled { get; set; }
        public RSAParameters PublicKey {get; set;}
    }
}
