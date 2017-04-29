using BlackJackWcfService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackWcfService.Service
{
    interface IClientCallback
    {
        [OperationContract(IsOneWay = true)]
        void UpdatePlayerList(PlayerList players);

        [OperationContract(IsOneWay = true)]
        void BattleStarted(List<GamePlayer> players);

        [OperationContract(IsOneWay = true)]
        void PlayerMoved(GamePlayer player);
    }
}
