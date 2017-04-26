using BJLogicLevel.GameLogic;
using BlackJackWcfService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BlackJackWcfService.Model;
using BJDataLevel.Providers;
using BJDataLevel.Providers.LocalDBProvider;

namespace BlackJackWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(IncludeExceptionDetailInFaults =true)]
    public class GameService : IGameService
    {
        private static List<IClientCallback> callbackList = new List<IClientCallback>();

        public int Login(string login, string pasword)
        {
            IProvider provider = new ProviderLocalDB();
            return provider.LoginUser(login, pasword);
        }

        public int Registration(string login, string pasword)
        {
            IProvider provider = new ProviderLocalDB();
            return provider.RegistationUser(login, pasword);
        }












        private void SendPlayers(IClientCallback current)
        {
            foreach (var callback in callbackList)
            {
                if (callback != current) callback.UpdatePlayerList(GameCore.Players);
            }
        }

        public void Logout(int id)
        {
            if (!GameCore.Players.Players.ContainsKey(id)) throw new Exception("User with id " + id + " not founded!");
            GameCore.Players.Players.Remove(id);

            var callback = OperationContext.Current.GetCallbackChannel<IClientCallback>();
            if (callbackList.Contains(callback))
            {
                callbackList.Remove(callback);
            }

            SendPlayers(callback);
        }


        public void PlayerMove(int id, int x, int y)
        {
            GameCore.PlayerMove(id, x, y);
        }

        public PlayerList GetPlayers()
        {
            return GameCore.Players;
        }
    }
}
