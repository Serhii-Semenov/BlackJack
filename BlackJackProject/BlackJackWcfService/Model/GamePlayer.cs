using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackWcfService.Model
{
    [DataContract]
    public class GamePlayer
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int SomeArtibute1 { get; set; }

        [DataMember] 
        public int SomeAtribute2 { get; set; }
    }
}
