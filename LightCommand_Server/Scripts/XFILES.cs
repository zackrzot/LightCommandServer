using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LightCommand_Server.Scripts
{
    public class XFILES : LightSequence
    {
        public XFILES()
        {
            Loop = true;
            Name = "XFILES";
        }

        public override void Sequence()
        {

            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT1, true);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT2, true);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT1, LightCtrl.Gobo.OPEN);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT2, LightCtrl.Gobo.OPEN);
            LightCtrl.SetColor(LightCtrl.Light.LIGHT2, LightCtrl.Color.LGREEN);
            LightCtrl.SetColor(LightCtrl.Light.LIGHT1, LightCtrl.Color.LGREEN);
            LightCtrl.SetStrobe(LightCtrl.Light.LIGHT1, true);
            LightCtrl.SetStrobe(LightCtrl.Light.LIGHT2, true);

            // Movement
            while (!ScriptControl.GetStopLights())
            {
                Random rnd = new Random();
                int l1t = rnd.Next(170, 200);
                LightCtrl.SetPan(LightCtrl.Light.LIGHT1, rnd.Next(50, 100));
                LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, rnd.Next(160, 210));
                LightCtrl.SetPan(LightCtrl.Light.LIGHT2, rnd.Next(70, 120));
                LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, rnd.Next(160, 210));
            }

        }



    } 
}
