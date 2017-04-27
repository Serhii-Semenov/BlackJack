using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackWcfService.Model
{
    [DataContract]
    public enum Suit
    {
        [DataMember]
        Heart = 3,
        [DataMember]
        Club = 4,
        [DataMember]
        Diamond = 5,
        [DataMember]
        Spade = 6,
        //[DataMember]
        //NS = 255,
    };

    [DataContract]
    public enum Color
    {
        [DataMember]
        Red = 12,
        [DataMember]
        Black = 8,
        [DataMember]
        White = 7,
        [DataMember]
        YELLOW = 6,
    };

    [DataContract]
    public enum Fase
    {
        [DataMember]
        Deuce = 50,
        [DataMember]
        Three = 51,
        [DataMember]
        Four = 52,
        [DataMember]
        Five = 53,
        [DataMember]
        Six = 54,
        [DataMember]
        Seven = 55,
        [DataMember]
        Eight = 56,
        [DataMember]
        Nine = 57,
        [DataMember]
        Ten = 58,
        [DataMember]
        Jack = 74,
        [DataMember]
        Queen = 81,
        [DataMember]
        King = 75,
        [DataMember]
        Ace = 84,
        [DataMember]
        Zero = 255,
    };
}
