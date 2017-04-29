
using BlackJack.GameService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJLogicLevel.GameLogic
{
    static class GameCore
    {
        //private static int nextPlayerId;

        //public static int NextPlayerId { get { return ++nextPlayerId; } }

        //public static PlayerList Players { get; set; }

        //private static int roomCapacity = 2;
        //private static Room currentRoom = new Room();
        //private static List<Room> rooms = new List<Room>();


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
