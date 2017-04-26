using BJDataLevel.Model;
using System.Collections.Generic;

namespace BJDataLevel.Providers
{
    public interface IProvider
    {
        List<Players> GetPlayers();

        int LoginUser(string login, string password);

        int RegistationUser(string login, string password);

    }
}
