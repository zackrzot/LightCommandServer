using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LightCommand_Server.Scripts
{
    public class BACKL : LightSequence
    {
        public BACKL()
        {
            Loop = true;
            Name = "BACKL";
        }

        public override void Sequence()
        {

            LightCtrl.SetGobo(LightCtrl.Light.LIGHT2, LightCtrl.Gobo.OPEN);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT2, true);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT1, false);

            LightCtrl.SetPan(LightCtrl.Light.LIGHT2, 83);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, 193);

        }



    } 
}
