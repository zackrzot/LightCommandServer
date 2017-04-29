using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LightCommand_Server.Scripts
{
    public class BREAK2 : LightSequence
    {
        public BREAK2()
        {
            Loop = true;
            Name = "BREAK2";
        }

        public override void Sequence()
        {

            LightCtrl.SetPan(LightCtrl.Light.LIGHT1, 81);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, 185);
            LightCtrl.SetPan(LightCtrl.Light.LIGHT2, 90);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, 182);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT1, LightCtrl.Gobo.OPEN);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT1, true);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT2, true);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT2, LightCtrl.Gobo.DOTS);
            LightCtrl.SetColor(LightCtrl.Light.LIGHT2, LightCtrl.Color.WHITE);
            LightCtrl.SetColor(LightCtrl.Light.LIGHT1, LightCtrl.Color.ROTATE);

            Thread.Sleep(1000);


        }



    } 
}
