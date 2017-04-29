using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LightCommand_Server.Scripts
{
    public class MIDDLEL : LightSequence
    {
        public MIDDLEL()
        {
            Loop = true;
            Name = "MIDDLEL";
        }

        public override void Sequence()
        {
            LightCtrl.SetColor(LightCtrl.Light.LIGHT2, LightCtrl.Color.WHITE);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT2, LightCtrl.Gobo.OPEN);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT2, true);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT1, false);

            LightCtrl.SetPan(LightCtrl.Light.LIGHT2, 95);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, 197);


        }



    } 
}
