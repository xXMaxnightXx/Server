using AltV.Net;
using System;

namespace altV_Template
{
    class ServerMain: Resource 
    {
        public override void OnStart()
        {
            Alt.Log("----> Server wird gestartet! <----");
        }

        public override void OnStop()
        {
            Alt.Log("----> Server wird beendet! <----");
        }
    }
}
