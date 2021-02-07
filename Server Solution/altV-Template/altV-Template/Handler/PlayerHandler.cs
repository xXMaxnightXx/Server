using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace altV_Template.Handler
{
    class PlayerHandler : IScript
    {
        [ScriptEvent(ScriptEventType.PlayerConnect)]
        public void OnPlayerConnect(IPlayer player, string reason)
        {

            player.Model = (uint)PedModel.FreemodeMale01;
            player.Spawn(new Position(0, 0, 75), 0);
            player.Emit("altvtutorial:configflags");

        }
    }
}
