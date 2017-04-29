using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LightCommand_Server.Scripts
{
    public class SCRATCH : LightSequence
    {
        public SCRATCH()
        {
            Loop = false;
            Name = "SCRATCH";
        }

        public override void Sequence()
        {
            LightCtrl.SetColor(LightCtrl.Light.LIGHT1, LightCtrl.Color.RED);
            LightCtrl.SetColor(LightCtrl.Light.LIGHT2, LightCtrl.Color.RED);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT1, LightCtrl.Gobo.LINE);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT2, LightCtrl.Gobo.LINE);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT1, true);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT2, true);

            for (int x = 0; x < 4; x++)
            {
                LightCtrl.SetPan(LightCtrl.Light.LIGHT1, 75);
                LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, 188);
                LightCtrl.SetPan(LightCtrl.Light.LIGHT2, 100);
                LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, 187);
                Thread.Sleep(500);
            }

            LightCtrl.AllOff();


        }



    } 
}
