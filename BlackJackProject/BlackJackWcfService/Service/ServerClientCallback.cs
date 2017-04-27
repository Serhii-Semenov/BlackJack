namespace BlackJackWcfService.Service
{
    class ServerClientCallback
    {
        IClientCallback callback;

        public ServerClientCallback(IClientCallback callback)
        {
            this.callback = callback;
        }

        //public void UpdatePlayerList(PlayerList players)
        //{
        //    callback.UpdatePlayerList(players);
        //}
    }
}
