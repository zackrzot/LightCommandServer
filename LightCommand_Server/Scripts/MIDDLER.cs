using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LightCommand_Server.Scripts
{
    public class MIDDLER : LightSequence
    {
        public MIDDLER()
        {
            Loop = true;
            Name = "MIDDLER";
        }

        public override void Sequence()
        {
            LightCtrl.SetColor(LightCtrl.Light.LIGHT1, LightCtrl.Color.WHITE);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT1, LightCtrl.Gobo.OPEN);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT1, true);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT2, false);

            LightCtrl.SetPan(LightCtrl.Light.LIGHT1, 70);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, 179);

        }



    } 
}
