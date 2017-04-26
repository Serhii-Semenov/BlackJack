using System.Collections.Generic;
using BlackJackWcfService.Model;
using BlackJackWcfService.Service;

namespace BJLogicLevel.GameLogic
{
    class Room
    {
        public Dictionary<IClientCallback, GamePlayer> Players { get; set; }

        public Room()
        {
            Players = new Dictionary<IClientCallback, GamePlayer>();
        }

        public int PlayersCount { get { return Players.Count; } }

        public void AddPlayer(IClientCallback callback, Player player)
        {
            Players.Add(callback, new GamePlayer { Id = player.Id});
        }
    }
}
