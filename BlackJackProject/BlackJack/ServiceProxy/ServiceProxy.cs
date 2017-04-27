using BlackJack.ClientGameLogic;
using BlackJack.GameService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.ServiceProxy
{
    public class ServiceProxy
    {
        public GameServiceClient service { get; private set; }
        
        private static ServiceProxy instance;
        public static ServiceProxy Instance
        {
            get
            {
                if (instance == null) instance = new ServiceProxy();
                return instance;
            }
        }

        private ServiceProxy()
        {
            service = new GameServiceClient(new InstanceContext(new ClientCallback()));
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
        }

        internal int Login(string login, string password)
        {
            return service.Login(login, password);
        }
    }
}
