using BlackJackWcfService.Model;
using BlackJackWcfService.Service;
using System.ServiceModel;


namespace BlackJackWcfService
{
    [ServiceContract(CallbackContract = typeof(IClientCallback), SessionMode = SessionMode.Required)]
    public interface IGameService
    {
        [OperationContract]
        int Login(string login, string pasword);

        [OperationContract]
        int Registration(string login, string pasword);

        [OperationContract]
        void Logout(int id);

        [OperationContract]
<<<<<<< HEAD
        int PlayerWisComp(int idPlayer);

        //[OperationContract]
        //int PlayerWisComp();


        //[OperationContract]
        //PlayerList GetPlayers();
=======
        PlayerList GetPlayers();

        [OperationContract]
        int GetBalanse(int id);
        [OperationContract]
        int ChangeBalance(int id, int coins);
        [OperationContract]
        int GetCredit(int id);
>>>>>>> develop
    }
}
