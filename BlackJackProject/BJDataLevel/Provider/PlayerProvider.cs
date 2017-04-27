using BJDataLevel.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJDataLevel.Provider
{
    public class PlayerProvider
    {
        public List<string> GetPlayers()
        {
            using (UserContext db = new UserContext())
            {
                // создаем два объекта User
                Player user1 = new Player { Login = "Tom", Password ="bls" };
                Player user2 = new Player { Login = "Tom2", Password = "bls" };

                // добавляем их в бд
                db.Players.Add(user1);
                db.Players.Add(user2);
                db.SaveChanges();
            }

            using (UserContext db = new UserContext())
            {
                return db.Players.Select(p => p.Login).ToList();
            }
            return null;
        }
    }
}
