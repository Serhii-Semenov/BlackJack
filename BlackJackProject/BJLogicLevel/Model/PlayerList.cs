
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackWcfService.Model
{
    [DataContract]
    public class PlayerList
    {
        [DataMember]
        public Dictionary<int, Player> Players { get; set; }

        public PlayerList()
        {
            Players = new Dictionary<int, Player>();
        }
    }
}
