using BlackJackWcfService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackWcfService.Service
{
    class ServerClientCallback
    {
        IClientCallback callback;

        public ServerClientCallback(IClientCallback callback)
        {
            this.callback = callback;
        }

        public void UpdatePlayerList(PlayerList players)
        {
            callback.UpdatePlayerList(players);
        }
    }
}
