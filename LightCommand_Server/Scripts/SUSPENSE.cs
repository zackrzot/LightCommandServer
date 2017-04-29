using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LightCommand_Server.Scripts
{
    public class SUSPENSE : LightSequence
    {
        public SUSPENSE()
        {
            Loop = true;
            Name = "SUSPENSE";
        }

        public override void Sequence()
        {


            LightCtrl.SetPan(LightCtrl.Light.LIGHT1, 81);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, 185);
            LightCtrl.SetPan(LightCtrl.Light.LIGHT2, 90);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, 182);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT1, true);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT2, true);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT1, LightCtrl.Gobo.SWIRLCROSS);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT2, LightCtrl.Gobo.SWIRL);
            LightCtrl.SetColor(LightCtrl.Light.LIGHT2, LightCtrl.Color.PINK);
            LightCtrl.SetColor(LightCtrl.Light.LIGHT1, LightCtrl.Color.DBLUE);


            // Movement
            while (!ScriptControl.GetStopLights())
            {
                LightCtrl.SetPan(LightCtrl.Light.LIGHT1, 65);
                LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, 200);
                LightCtrl.SetPan(LightCtrl.Light.LIGHT2, 100);
                LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, 180);

                Thread.Sleep(1000);

                LightCtrl.SetPan(LightCtrl.Light.LIGHT1, 90);
                LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, 183);
                LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, 180);
                LightCtrl.SetPan(LightCtrl.Light.LIGHT2, 55);

                Thread.Sleep(1000);

            }
        }



    } 
}
