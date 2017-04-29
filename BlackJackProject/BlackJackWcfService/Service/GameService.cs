using BlackJackWcfService.Service;
using System.Collections.Generic;
using System.ServiceModel;
using BJDataLevel.Providers;
using BJDataLevel.Providers.LocalDBProvider;
using BlackJackWcfService.GameLogic;

namespace BlackJackWcfService
{
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
            if (!GameCore.Players.Players.ContainsKey(id)) throw new System.Exception("User with id " + id + " not founded!");
            GameCore.Players.Players.Remove(id);

            var callback = OperationContext.Current.GetCallbackChannel<IClientCallback>();
            if (callbackList.Contains(callback))
            {
                callbackList.Remove(callback);
            }

            SendPlayers(callback);
        }


        //public void PlayerMove(int id, int x, int y)
        //{
        //    GameCore.PlayerMove(id, x, y);
        //}

        //public PlayerList GetPlayers()
        //{
        //    return GameCore.Players;
        //}
    }
}
