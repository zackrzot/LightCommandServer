using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LightCommand_Server.Scripts
{
    public class USA : LightSequence
    {
        public USA()
        {
            Loop = true;
            Name = "USA";
        }

        public override void Sequence()
        {
            LightCtrl.SetColor(LightCtrl.Light.LIGHT1, LightCtrl.Color.WHITE);
            LightCtrl.SetColor(LightCtrl.Light.LIGHT2, LightCtrl.Color.WHITE);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT1, LightCtrl.Gobo.OPEN);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT2, LightCtrl.Gobo.OPEN);
            LightCtrl.SetPan(LightCtrl.Light.LIGHT1, 39);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, 211);
            LightCtrl.SetPan(LightCtrl.Light.LIGHT2, 133);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, 211);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT1, true);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT2, true);

                        // Movement
            while (!ScriptControl.GetStopLights())
            {
                LightCtrl.SetColor(LightCtrl.Light.LIGHT1, LightCtrl.Color.RED);
                LightCtrl.SetColor(LightCtrl.Light.LIGHT2, LightCtrl.Color.WHITE);
                Thread.Sleep(1000);
                LightCtrl.SetColor(LightCtrl.Light.LIGHT1, LightCtrl.Color.DBLUE);
                LightCtrl.SetColor(LightCtrl.Light.LIGHT2, LightCtrl.Color.WHITE);
                Thread.Sleep(1000);
                LightCtrl.SetColor(LightCtrl.Light.LIGHT1, LightCtrl.Color.WHITE);
                LightCtrl.SetColor(LightCtrl.Light.LIGHT2, LightCtrl.Color.RED);
                Thread.Sleep(1000);
                LightCtrl.SetColor(LightCtrl.Light.LIGHT1, LightCtrl.Color.WHITE);
                LightCtrl.SetColor(LightCtrl.Light.LIGHT2, LightCtrl.Color.DBLUE);
                Thread.Sleep(1000);
            }



        }



    } 
}
