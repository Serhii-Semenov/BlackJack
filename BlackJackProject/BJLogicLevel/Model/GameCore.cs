using BJLogicLevel.Model;
using BlackJackWcfService.Model;
﻿using System;
using System.Collections.Generic;


namespace BJLogicLevel.Model
{
    public static class GameCore
    {
        private static List<GamesRoom> rooms;

        static GameCore()
        {
           rooms = new List<GamesRoom>();
        }

       public static int PlayerWisComp(Player pl, int rate)
        {
            GamesRoom temp = new GamesRoom(rate);
            Player comp = new Player { Nickname = "comp", Id = -1, Money = 1000, Rate = 20 };
            temp.PlList.Add(pl);
            temp.PlList.Add(comp);
            rooms.Add(temp);
            return temp.id;
        }

        public static void NewGame(int id, int rate)
        {
            foreach (var temp in rooms)
                if (temp.id == id)
                {
                    temp.NewGame();
                }
        }

       public static Ccard GiveCard(int id, Player pl)
        {
            foreach (var temp in rooms)
                if (temp.id == id)
                {
                    foreach (var temp2 in temp.PlList)
                    {
                        if (temp2 == pl)
                        {
                            return temp.GiveCard(pl);
                        }
                    }
                }
           return new Ccard();
        }


        public static void GoBot(int id)
        {
            int point=0;
            int pointbot=0;
            foreach (var temp in rooms)
                if (temp.id == id)
                {
                    foreach (var temp2 in temp.PlList)
                    {
                        if (temp2.Nickname != "comp")
                        {

                            foreach (var cardpoint in temp2.CardList)
                            {
                                point += cardpoint.points;
                            }
                        }
                    }
                }
            if (point > 21)
                return;
            while (pointbot < point && pointbot < 22)
            {
                foreach (var temp in rooms)
                    if (temp.id == id)
                    {
                        foreach (var temp2 in temp.PlList)
                        {
                            if (temp2.Nickname == "comp")
                            {
                                Ccard car = temp.GiveCard(temp2);
                                pointbot += car.points;
                            }
                        }
                    }
            }
        }




        //private static int nextPlayerId;
		
        //private static GamesRoom currentRoom = new GamesRoom();
        //private static List<GamesRoom> rooms = new List<GamesRoom>();
		

        //public static int CreateNewGameRoom()
        //{
        //    GamesRoom temp = new GamesRoom();
        //    rooms.Add(temp);
        //    return temp.id;
        //}

        //public static GamesRoom GiveGameRoom(int id)
        //{
        //    return rooms.Where(p => p.id == id).FirstOrDefault();
        //}

  


        //static GameCore()
        //{
        //    Players = new PlayerList();
        //}

        //public static void AddPlayer(Player player, IClientCallback callback)
        //{
        //    Players.Players.Add(player.Id, player);

        //    currentRoom.AddPlayer(callback, player);
        //    if (currentRoom.PlayersCount == roomCapacity)
        //    {
        //        rooms.Add(currentRoom);
        //        currentRoom = new Room();
        //    }
        //}

        //public static void PlayerMove(int id, int x, int y)
        //{
        //    foreach (var r in rooms)
        //    {
        //        foreach (var p in r.Players)
        //        {
        //            if (p.Value.Id == id)
        //            {
        //                //p.Value.X = x;
        //                //p.Value.Y = y;
        //                BroadcastPlayers(p.Value.Id, r);
        //                break;
        //            }
        //        }
        //    }
        //}

        //private static void BroadcastPlayers(int id, Room room)
        //{
        //    foreach (var p in room.Players)
        //    {
        //        if (id != p.Value.Id) p.Key.PlayerMoved(p.Value);
        //    }
        //}
    }
}
