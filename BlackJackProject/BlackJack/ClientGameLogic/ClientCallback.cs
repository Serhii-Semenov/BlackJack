
using BlackJack.GameService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
