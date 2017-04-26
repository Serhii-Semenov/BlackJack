﻿using BJDataLevel.Model;
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
    }
}
