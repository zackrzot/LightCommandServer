using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LightCommand_Server.Scripts
{
    public class FRONTR : LightSequence
    {
        public FRONTR()
        {
            Loop = true;
            Name = "FRONTR";
        }

        public override void Sequence()
        {
            LightCtrl.SetColor(LightCtrl.Light.LIGHT1, LightCtrl.Color.WHITE);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT1, LightCtrl.Gobo.OPEN);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT1, true);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT2, false);
   
            LightCtrl.SetPan(LightCtrl.Light.LIGHT1, 90);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, 173);


        }



    } 
}
