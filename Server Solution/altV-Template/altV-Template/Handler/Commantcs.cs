using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using AltV.Net.Resources.Chat.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altv_Roleplay.Handler
{
    public class Commands : IScript
    {
        [Command("veh")]
        public static void CMD_CreateVehicle(IPlayer player, string vehName, int r = 0, int g = 0, int b = 0)
        {
            uint vehHash = Alt.Hash(vehName);
            if (!Enum.IsDefined(typeof(VehicleModel), vehHash))
            {
                player.SendChatMessage("[Server] Ungültiger Fahrzeugname!");
                return;
            }

            IVehicle veh = Alt.CreateVehicle(vehHash, GetPositionAround(player.Position, 5.0f), player.Rotation);            
            veh.PrimaryColorRgb = new Rgba(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b), 255);
            veh.SecondaryColorRgb = new Rgba(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b), 255);
            player.SendChatMessage("Fahrzeug gespawnt!");
        }

        public static Position GetPositionAround(Position pos, float range)
        {
            Random rnd = new Random();
            float x = pos.X + (float)rnd.NextDouble() * (range * 2) - range;
            float y = pos.Y + (float)rnd.NextDouble() * (range * 2) - range;
            return new Position(x, y, pos.Z);
        }
    }
}
