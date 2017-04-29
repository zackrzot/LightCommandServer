using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightCommand_Server
{
    public class Logger
    {

        private static LightCommandServerForm activeForm = null;

        public static void Initialize(LightCommandServerForm f)
        {
            activeForm = f;
            activeForm.PrintToLog("Logging initialized.");
        }

        public static void Log(String text)
        {
            if (activeForm == null)
                return;
            activeForm.PrintToLog(DateTime.Now.ToString("h:mm:ss tt : ") + text);
        }

        public static void SetIPText(string text)
        {
            activeForm.SetIPText(text);
        }

        public static void SetSocketState(SocketState ss)
        {
            activeForm.SetSocketState(ss);
        }

        public static void SetLightStatus(LightStatus ls)
        {
            activeForm.SetLightStatus(ls);
            ScriptControl.CurrentLightStatus = ls;
        }

        public static void SetClientStatus(ClientStatus cs)
        {
            activeForm.SetClientStatus(cs);
        }

    }
}
