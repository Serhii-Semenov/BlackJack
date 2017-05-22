using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJLogicLevel.Model
{
    static class GameCore
    {
        private static GamesRoom currentRoom = new GamesRoom();
        private static List<GamesRoom> rooms = new List<GamesRoom>();

        public static int CreateNewGameRoom()
        {
            GamesRoom temp = new GamesRoom();
            rooms.Add(temp);
            return temp.id;
        }

        public static GamesRoom GiveGameRoom(int id)
        {
            return rooms.Where(p => p.id == id).FirstOrDefault();
        }

  


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
