using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LightCommand_Server.Scripts
{
    public class TRIPLE : LightSequence
    {
        public TRIPLE()
        {
            Loop = false;
            Name = "TRIPLE";
        }

        public override void Sequence()
        {
            LightCtrl.SetColor(LightCtrl.Light.LIGHT1, LightCtrl.Color.PINK);
            LightCtrl.SetColor(LightCtrl.Light.LIGHT2, LightCtrl.Color.MAGENTA);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT1, LightCtrl.Gobo.STARS);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT2, LightCtrl.Gobo.STARS);
            LightCtrl.SetPan(LightCtrl.Light.LIGHT1, 81);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, 185);
            LightCtrl.SetPan(LightCtrl.Light.LIGHT2, 90);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, 182);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT1, true);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT2, true);

            // light 1 MR pocket
            LightCtrl.SetPan(LightCtrl.Light.LIGHT1, 70);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, 180);
            // light 2 ML pocket
            LightCtrl.SetPan(LightCtrl.Light.LIGHT2, 95);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, 193);

            Thread.Sleep(1000);

            // light 1 center center back
            LightCtrl.SetPan(LightCtrl.Light.LIGHT1, 68);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, 192);
            // light 2 center center front
            LightCtrl.SetPan(LightCtrl.Light.LIGHT2, 104);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, 190);

            Thread.Sleep(1000);


            // light 1 MR pocket
            LightCtrl.SetPan(LightCtrl.Light.LIGHT1, 70);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, 180);
            // light 2 ML pocket
            LightCtrl.SetPan(LightCtrl.Light.LIGHT2, 95);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, 193);

            Thread.Sleep(1000);

            // light 1 center center back
            LightCtrl.SetPan(LightCtrl.Light.LIGHT1, 68);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, 192);
            // light 2 center center front
            LightCtrl.SetPan(LightCtrl.Light.LIGHT2, 104);
            LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, 190);


            LightCtrl.AllOff();
        }


    } 
}
