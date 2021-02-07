using AltV.Net;
using AltV.Net.Elements.Entities;
using AltV.Net.Resources.Chat.Api;
using System;
using System.Collections.Generic;
using System.Text;

namespace altV_Template.Handler
{
    class ChatHandler: IScript
    {
        [ClientEvent("chat:message")]
        public void OnChatMessage(IPlayer player, string msg)
        {
            if (msg.Length == 0 || msg[0] == '/') return;
            foreach (IPlayer target in Alt.GetAllPlayers())
            {
                if (target.Position.Distance(player.Position) <= 10)
                {
                    player.SendChatMessage($"{player.Name} sagt: {msg}");
                }
            }                       
        }
    }
}
