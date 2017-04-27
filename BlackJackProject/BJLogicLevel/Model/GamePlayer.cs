using System.Runtime.Serialization;

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
