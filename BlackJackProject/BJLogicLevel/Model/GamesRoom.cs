using BlackJackWcfService.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BJLogicLevel.Model
{
   
    public class GamesRoom
    {
<<<<<<< HEAD
        public int id { get; set;}
        CDeck dec;
        public List<Player> PlList;
        public int rate;

        public GamesRoom(int r)
        {
            dec = new CDeck();
            PlList = new List<Player>();
            id = Singleton.getInstance().IDGame++;
            rate = r;
=======
        public int id { get; private set; }
        CDeck dec;
        public List<Player> PlList;
        public GamesRoom()
        {
            dec = new CDeck();
            PlList = new List<Player>();
            id = GamesNumber.getInstance();
>>>>>>> develop
        }

        public void NewGame()
        {
            dec = new CDeck();
            foreach (var player in PlList)
            {
                player.CardList.Clear();
            }
        }

        public Ccard GiveCard(Player player)
        {
            Ccard temp = dec.deck.Dequeue();
            player.CardList.Add(temp);
            return temp;
        }

        public List<Player> CkeckWin()
        {
            List<Player> Win = new List<Player>();
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
                    Win.Add(players);
            }
            return Win;
        }
    }
}
