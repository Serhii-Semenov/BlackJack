using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackWcfService.Model
{
    [DataContract]
    public class Player
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Nickname { get; set; }

        [DataMember]
        public int Money { get; set; }

        //[DataMember]
        //public List<Ccard> CardList;
        //public Player()
        //{
        //    List<Ccard> CardList = new List<Ccard>();
        //}
    }
}
