using BlackJack.ServiceReference;
using BlackJackWcfService.Model;
using System;
using System.Collections.Generic;

namespace BlackJack.ClientGameLogic
{
    public class ClientCallback : IGameServiceCallback
    {
        public event Action<PlayerList> PlayersUpdated;
        public event Action<List<GamePlayer>> GameStarted;
        public event Action<GamePlayer> GamePlayerMoved;

        public void UpdatePlayerList(PlayerList players)
        {
            if (PlayersUpdated != null) PlayersUpdated(players);
            //PlayersUpdated?.Invoke(players);
        }


        public void BattleStarted(GamePlayer[] players)
        {
            if (GameStarted != null) GameStarted(new List<GamePlayer>(players));
        }

        public void PlayerMoved(GamePlayer player)
        {
            if (GamePlayerMoved != null) GamePlayerMoved(player);
        }
    }
}
