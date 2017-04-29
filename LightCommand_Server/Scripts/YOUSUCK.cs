using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LightCommand_Server.Scripts
{
    public class YOUSUCK : LightSequence
    {
        public YOUSUCK()
        {
            Loop = false;
            Name = "YOUSUCK";
        }

        public override void Sequence()
        {
            LightCtrl.SetColor(LightCtrl.Light.LIGHT1, LightCtrl.Color.YELLOW);
            LightCtrl.SetColor(LightCtrl.Light.LIGHT2, LightCtrl.Color.YELLOW);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT1, LightCtrl.Gobo.OPEN);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT2, LightCtrl.Gobo.OPEN);
            LightCtrl.SetPan(LightCtrl.Light.LIGHT1, 81);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, 185);
            LightCtrl.SetPan(LightCtrl.Light.LIGHT2, 90);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, 182);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT1, true);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT2, true);

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    LightCtrl.SetStrobe(LightCtrl.Light.LIGHT1, true);
                    LightCtrl.SetStrobe(LightCtrl.Light.LIGHT2, true);

                    Thread.Sleep(100);
                }

                for (int z = 0; z < 5; z++)
                {
                    LightCtrl.SetStrobe(LightCtrl.Light.LIGHT1, false);
                    LightCtrl.SetStrobe(LightCtrl.Light.LIGHT2, false);
                    LightCtrl.LightOnOff(LightCtrl.Light.LIGHT1, true);
                    LightCtrl.LightOnOff(LightCtrl.Light.LIGHT2, true);

                    Thread.Sleep(100);
                }
            }

            LightCtrl.AllOff();
        }



    } 
}
