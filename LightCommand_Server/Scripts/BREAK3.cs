using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LightCommand_Server.Scripts
{
    public class BREAK3 : LightSequence
    {
        public BREAK3()
        {
            Loop = true;
            Name = "BREAK3";
        }

        public override void Sequence()
        {
            LightCtrl.SetPan(LightCtrl.Light.LIGHT1, 81);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, 185);
            LightCtrl.SetPan(LightCtrl.Light.LIGHT2, 90);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, 182);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT1, true);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT2, true);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT1, LightCtrl.Gobo.ROTATE);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT2, LightCtrl.Gobo.ROTATE);
            LightCtrl.SetColor(LightCtrl.Light.LIGHT2, LightCtrl.Color.LBLUE);
            LightCtrl.SetColor(LightCtrl.Light.LIGHT1, LightCtrl.Color.YELLOW);


            // Movement
            while (!ScriptControl.GetStopLights())
            {
                LightCtrl.SetPan(LightCtrl.Light.LIGHT1, 69);
                LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, 192);
                LightCtrl.SetPan(LightCtrl.Light.LIGHT2, 104);
                LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, 191);

                Thread.Sleep(1000);

                LightCtrl.SetPan(LightCtrl.Light.LIGHT1, 81);
                LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, 182);
                LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, 182);
                LightCtrl.SetPan(LightCtrl.Light.LIGHT2, 90);

                Thread.Sleep(1000);

            }

        }



    } 
}
