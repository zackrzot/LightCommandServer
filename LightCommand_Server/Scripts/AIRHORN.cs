using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LightCommand_Server.Scripts
{
    public class AIRHORN : LightSequence
    {
        public AIRHORN()
        {
            Loop = false;
            Name = "AIRHORN";
        }

        public override void Sequence()
        {
            LightCtrl.SetColor(LightCtrl.Light.LIGHT1, LightCtrl.Color.ROTATE);
            LightCtrl.SetColor(LightCtrl.Light.LIGHT2, LightCtrl.Color.ROTATE);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT1, LightCtrl.Gobo.ROTATE);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT2, LightCtrl.Gobo.ROTATE);
            LightCtrl.SetPan(LightCtrl.Light.LIGHT1, 81);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, 185);
            LightCtrl.SetPan(LightCtrl.Light.LIGHT2, 90);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, 182);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT1, true);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT2, true);

            for (int y = 0; y < 2; y++)
            {
                LightCtrl.SetStrobe(LightCtrl.Light.LIGHT1, true);
                LightCtrl.SetStrobe(LightCtrl.Light.LIGHT2, true);

                Thread.Sleep(100);
            }


            LightCtrl.AllOff();


        }



    } 
}
