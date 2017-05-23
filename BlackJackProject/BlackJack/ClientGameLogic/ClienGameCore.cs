using BlackJack.BJService;
using BlackJack.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.ClientGameLogic;
using BlackJackWcfService.Model;

namespace BlackJack.ClientGameLogic
{
    static class ClientGameCore
    {
        public static ClientStatus Status { get; set; }

        public static Player Player { get; set; }

        public static PlayerList Players { get; set; }
    }
}
