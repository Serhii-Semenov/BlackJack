using BlackJackWcfService.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BJLogicLevel.Model
{
    [DataContract]
    public class GamesRoom
    {
        [DataMember]
        int id { get; set; }
        CDeck dec;
        List<Player> PlList;

        public GamesRoom()
        {
            dec = new CDeck();
            PlList = new List<Player>();
        }

        public void NewGame()
        {
            dec = new CDeck();
            foreach (var player in PlList)
            {
                player.CardList.Clear();
            }
        }

        public Ccard GiveCard(int playerId)
        {
            Ccard temp = dec.deck.Dequeue();
            foreach (var players in PlList)
            {
                if (players.Id == playerId)
                {
                    players.CardList.Add(temp);
                    break;
                }
            }
            return temp;
        }

        public List<int> CkeckWin()
        {
            List<int> Win = new List<int>();
            int max = 0;
            int temp;
            foreach (var players in PlList)
            {
                temp = 0;
                foreach (var cardpoint in players.CardList)
                {
                    temp += cardpoint.points;
                }
                if (temp < 22 && temp > max)
                    max = temp;
            }

            foreach (var players in PlList)
            {
                temp = 0;
                foreach (var cardpoint in players.CardList)
                {
                    temp += cardpoint.points;
                }
                if (temp == max)
                    Win.Add(players.Id);
            }
            return Win;
        }
    }
}
