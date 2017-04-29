using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LightCommand_Server.Scripts
{
    public class BREAK1 : LightSequence
    {
        public BREAK1()
        {
            Loop = true;
            Name = "BREAK1";
        }

        public override void Sequence()
        {
            LightCtrl.SetColor(LightCtrl.Light.LIGHT1, LightCtrl.Color.WHITE);
            LightCtrl.SetColor(LightCtrl.Light.LIGHT2, LightCtrl.Color.WHITE);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT1, LightCtrl.Gobo.OPEN);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT2, LightCtrl.Gobo.OPEN);
            LightCtrl.SetPan(LightCtrl.Light.LIGHT1, 81);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, 185);
            LightCtrl.SetPan(LightCtrl.Light.LIGHT2, 90);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, 182);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT1, true);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT2, true);

            Thread.Sleep(1000);

        }



    } 
}
