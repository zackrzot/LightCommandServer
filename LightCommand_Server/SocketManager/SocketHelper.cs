using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace LightCommand_Server
{
    public static class SocketHelper
    {
        public static void processMsg(String message)
        {
            // Get rid of the <EOF> marker
            message = message.Replace("<EOF>", "").Trim();

            // Handle the message received and  
            Logger.Log(String.Format("SocketHelpter: Message recieved: '{0}'", message));

            switch (message)
            {
                case "STOP":
                    LightCtrl.AllOff();
                    ScriptControl.StopLights();
                    break;
                case "BREAK1":
                    ScriptControl.RunScript(LightScript.BREAK1);
                    break;
                case "BREAK2":
                    ScriptControl.RunScript(LightScript.BREAK2);
                    break;
                case "BREAK3":
                    ScriptControl.RunScript(LightScript.BREAK3);
                    break;
                case "FINAL1":
                    ScriptControl.RunScript(LightScript.FINAL1);
                    break;
                case "FINAL2":
                    ScriptControl.RunScript(LightScript.FINAL2);
                    break;
                case "FINAL3":
                    ScriptControl.RunScript(LightScript.FINAL3);
                    break;
                case "TRIPLE":
                    ScriptControl.RunScript(LightScript.TRIPLE);
                    break;
                case "MILLIONAIRE":
                    ScriptControl.RunScript(LightScript.MILLIONARE);
                    break;
                case "XFILES":
                    ScriptControl.RunScript(LightScript.XFILES);
                    break;
                case "TRANCE":
                    ScriptControl.RunScript(LightScript.TRANCE);
                    break;
                case "YOUSUCK":
                    ScriptControl.RunScript(LightScript.YOUSUCK);
                    break;
                case "SCRATCH":
                    ScriptControl.RunScript(LightScript.SCRATCH);
                    break;
                case "FRONTR":
                    ScriptControl.RunScript(LightScript.FRONTR);
                    break;
                case "FRONTL":
                    ScriptControl.RunScript(LightScript.FRONTL);
                    break;
                case "MIDDLER":
                    ScriptControl.RunScript(LightScript.MIDDLER);
                    break;
                case "MIDDLEL":
                    ScriptControl.RunScript(LightScript.MIDDLEL);
                    break;
                case "BACKR":
                    ScriptControl.RunScript(LightScript.BACKR);
                    break;
                case "BACKL":
                    ScriptControl.RunScript(LightScript.BACKL);
                    break;
                case "AIRHORN":
                    ScriptControl.RunScript(LightScript.AIRHORN);
                    break;
                case "SUSPENSE":
                    ScriptControl.RunScript(LightScript.SUSPENSE);
                    break;
                case "USA":
                    ScriptControl.RunScript(LightScript.USA);
                    break;
                default:
                    Logger.Log("Unknown command sent from client: " + message);
                    break;
            }

        }


    }
}
