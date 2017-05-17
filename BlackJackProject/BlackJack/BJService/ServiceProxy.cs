using BlackJack.ClientGameLogic;
using BlackJack.BJService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using BlackJack.GameService;

namespace BlackJack.BJService
{
    public class ServiceProxy
    {
        public event Action Initialized;

        public ClientCallback Callback { get; private set; }
        public GameServiceClient service { get; private set; }

        private List<PlayerView> players = new List<PlayerView>();

        private static ServiceProxy instance;

        public static ServiceProxy Instance
        {
            get
            {
                if (instance == null) instance = new ServiceProxy();
                instance.Initialize();
                return instance;
            }
        }

        private ServiceProxy()
        {

        }

        private void Initialize()
        {
            if (service != null) return;

            Callback = new ClientCallback();
            service = new GameServiceClient(new InstanceContext(Callback));
        }

        internal int Registration(string v1, string v2)
        {
            return service.Registration(v1, v2);
        }

        internal void Logout(int id)
        {
            service.Logout(id);
        }

        internal void Close()
        {
            service.Close();
            service = null;
        }

        internal int Login(string login, string password)
        {
            return service.Login(login, password);
        }

        internal void Connect(string nickname, int id)
        {            
            Initialized();

            //service = new GameServiceClient(new InstanceContext(callback));

            ClientGameCore.Player = new Player() { Id = id, Nickname = nickname };
            ClientGameCore.Status = ClientStatus.Online;

        }

        internal PlayerList GetPlayers()
        {
            return service.GetPlayers();
        }

        internal int GetBalanse(int p)
        {
            return service.GetBalanse(p);
        }
    }
}
