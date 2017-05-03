using BlackJackWcfService.Model;

namespace BlackJackWcfService.Service
{
    class ServerClientCallback
    {
        IClientCallback Callback { get; set; }
        public int Id { get; set; }

        public void UpdatePlayerList(PlayerList players)
        {
            Callback.UpdatePlayerList(players);
        }

        public ServerClientCallback(int id, IClientCallback callback)
        {
           Callback = callback;
           Id = id;
        }
    }
}
