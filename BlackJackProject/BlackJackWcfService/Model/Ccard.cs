using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackWcfService.Model
{
    [DataContract]
    public class Ccard
    {
        [DataMember]
        public Suit suit { get; set; } //масть
        [DataMember]
        public int points { get; set; } //кол-во очков
        [DataMember]
        public Fase name { get; set; } //тип карты рисунок
    }
}
