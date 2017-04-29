using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LightCommand_Server.Scripts
{
    public class FINAL2 : LightSequence
    {
        public FINAL2()
        {
            Loop = true;
            Name = "FINAL2";
        }

        public override void Sequence()
        {
            LightCtrl.SetPan(LightCtrl.Light.LIGHT1, 81);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, 185);
            LightCtrl.SetPan(LightCtrl.Light.LIGHT2, 90);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, 182);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT1, true);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT2, true);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT1, LightCtrl.Gobo.OCT);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT2, LightCtrl.Gobo.OCT );
            LightCtrl.SetColor(LightCtrl.Light.LIGHT2, LightCtrl.Color.ROTATE);
            LightCtrl.SetColor(LightCtrl.Light.LIGHT1, LightCtrl.Color.ROTATE);
            LightCtrl.SetStrobe(LightCtrl.Light.LIGHT1, true);
            LightCtrl.SetStrobe(LightCtrl.Light.LIGHT2, true);

            // Movement
            while (!ScriptControl.GetStopLights())
            {
                Random rnd = new Random();
                int l1t = rnd.Next(170, 200);
                LightCtrl.SetPan(LightCtrl.Light.LIGHT1, rnd.Next(60, 90));
                Thread.Sleep(100);
                LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, rnd.Next(170, 200));
                Thread.Sleep(100);
                LightCtrl.SetPan(LightCtrl.Light.LIGHT2, rnd.Next(80, 110));
                Thread.Sleep(100);
                LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, rnd.Next(170, 200));
                Thread.Sleep(100);
            }


        }



    } 
}
