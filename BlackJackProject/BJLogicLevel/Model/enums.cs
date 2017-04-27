using System.Runtime.Serialization;

namespace BlackJackWcfService.Model
{
    [DataContract]
    public enum Suit
    {
        [EnumMember]
        Heart = 3,
        [EnumMember]
        Club = 4,
        [EnumMember]
        Diamond = 5,
        [EnumMember]
        Spade = 6,
    };

    [DataContract]
    public enum Fase
    {
        [EnumMember]
        Deuce = 50,
        [EnumMember]
        Three = 51,
        [EnumMember]
        Four = 52,
        [EnumMember]
        Five = 53,
        [EnumMember]
        Six = 54,
        [EnumMember]
        Seven = 55,
        [EnumMember]
        Eight = 56,
        [EnumMember]
        Nine = 57,
        [EnumMember]
        Ten = 58,
        [EnumMember]
        Jack = 74,
        [EnumMember]
        Queen = 81,
        [EnumMember]
        King = 75,
        [EnumMember]
        Ace = 84,
        [EnumMember]
        Zero = 255,
    };
}
