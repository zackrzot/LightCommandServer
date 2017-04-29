using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LightCommand_Server.Scripts
{
    public class MILLIONARE : LightSequence
    {
        public MILLIONARE()
        {
            Loop = false;
            Name = "MILLIONARE";
        }

        public override void Sequence()
        {

            LightCtrl.SetColor(LightCtrl.Light.LIGHT1, LightCtrl.Color.WHITE);
            LightCtrl.SetColor(LightCtrl.Light.LIGHT2, LightCtrl.Color.WHITE);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT1, LightCtrl.Gobo.OPEN);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT2, LightCtrl.Gobo.OPEN);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT1, true);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT2, true);

            for (int x = 0; x < 3; x++)
            {
                LightCtrl.SetPan(LightCtrl.Light.LIGHT1, 85);
                LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, 255);
                LightCtrl.SetPan(LightCtrl.Light.LIGHT2, 85);
                LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, 255);
                Thread.Sleep(500);
            }

            for (int x = 0; x < 4; x++)
            {
                LightCtrl.SetPan(90);
                LightCtrl.SetTilt(115);

                Thread.Sleep(500);
            }

            for (int x = 0; x < 8; x++)
            {
                LightCtrl.SetPan(LightCtrl.Light.LIGHT1, 81);
                LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, 185);
                LightCtrl.SetPan(LightCtrl.Light.LIGHT2, 90);
                LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, 182);

                Thread.Sleep(100);
            }

            LightCtrl.AllOff();

        }



    } 
}
