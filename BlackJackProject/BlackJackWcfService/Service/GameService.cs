using BlackJackWcfService.Service;
using System.Collections.Generic;
using System.ServiceModel;
using BJDataLevel.Providers;
using BJDataLevel.Providers.LocalDBProvider;
using BlackJackWcfService.GameLogic;
using BlackJackWcfService.Model;
using System;
using System.Linq;

namespace BlackJackWcfService
{
    //[ServiceBehavior(IncludeExceptionDetailInFaults =true)]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true, ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single)]

    public class GameService : IGameService
    {
        private static List<IClientCallback> callbackList = new List<IClientCallback>();

        public int Login(string login, string pasword)
        {
            if (GameCore.Players.Players.Values.Any(p => p.Nickname == login))
            {
                throw new Exception("Nickname already used!");
            }

            IProvider provider = new ProviderLocalDB();
            var ID =  provider.LoginUser(login, pasword);
            if (ID <= 0)  return ID;

            var callback = OperationContext.Current.GetCallbackChannel<IClientCallback>();
            if (!callbackList.Contains(callback))
            {
                var player = new Player() { Id = ID, Nickname = login };
                GameCore.AddPlayer(player, callback);
                callbackList.Add(callback);
                SendPlayers(callback);
                return ID;
            }
            throw new Exception();
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

        public PlayerList GetPlayers()
        {
            return GameCore.Players;
        }
    }
}
