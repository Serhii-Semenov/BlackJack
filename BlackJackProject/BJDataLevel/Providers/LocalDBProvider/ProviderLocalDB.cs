using BJDataLevel.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BJDataLevel.Providers.LocalDBProvider
{
    public class ProviderLocalDB : IProvider
    {
        public List<Players> GetPlayers()
        {
            using (BJContext db = new BJContext())
            {
                 return db.Players.ToList();
            }
        }

        public int LoginUser(string login, string password)
        {
            using (BJContext db = new BJContext())
            {

                if (db.Players.Where(p => p.Login == login && p.Password == password).Count() > 0)
                    return db.Players.Where(p => p.Login == login && p.Password == password).Select(p => p.Id).FirstOrDefault();

                else if (db.Players.Where(p => p.Login == login).Count() > 0)
                    return -1; //есть такой логин, но не подходит пароль

                return -2; //нет такого логина в базе
            }
        }

        public int RegistationUser(string login, string password)
        {
            using (BJContext db = new BJContext())
            {
                if (db.Players.Where(p => p.Login == login).Count() > 0)
                    return -1; //есть такой логин, но не подходит пароль
                else
                {
                    Players pl = new Players { Login = login, Password = password };
                    var temp = db.Players.Add(pl);
                    db.SaveChanges();
                    return temp.Id;
                }
            }
        }

        public int GetBalanse(int id)
        {
            using (BJContext db = new BJContext())
            {
                if (db.BalansPlayers.Where(p => p.IdPlayer == id).Count() == 0)
                {
                    BalansPlayers bl =new  BalansPlayers(){ IdPlayer = id, Balance = 1000, CreditBalance = 0 };
                    db.BalansPlayers.Add(bl);
                    db.SaveChanges();
                    return bl.Balance;
                }
                else
                {
                    return db.BalansPlayers.Where(p => p.IdPlayer == id).Select(p => p.Balance).FirstOrDefault();
                }
            }
       }

        public int ChangeBalance(int id, int coins)
        {
            using (BJContext db = new BJContext())
            {
                    BalansPlayers bl = db.BalansPlayers.Find(id);
                    bl.Balance += coins;
                    db.SaveChanges();
                    return bl.Balance;
           }
       }

        public int GetCredit(int id)
        {
            using (BJContext db = new BJContext())
            {
                BalansPlayers bl = db.BalansPlayers.Find(id);
                bl.Balance += 1000;
                bl.CreditBalance -= 1000;
                db.SaveChanges();
                return bl.Balance;
            }
        }

        public string GetNameById(int id)
        {
            using (BJContext db = new BJContext())
            {
                return db.Players.Where(p => p.Id == id).Select(p => p.Login).FirstOrDefault();
            }
       }
    }
}
