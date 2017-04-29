using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LightCommand_Server.Scripts
{
    public class TRANCE : LightSequence
    {
        public TRANCE()
        {
            Loop = true;
            Name = "TRANCE";
        }

        public override void Sequence()
        {
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT1, true);
            LightCtrl.LightOnOff(LightCtrl.Light.LIGHT2, true);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT1, LightCtrl.Gobo.ROTATE);
            LightCtrl.SetGobo(LightCtrl.Light.LIGHT2, LightCtrl.Gobo.ROTATE);
            LightCtrl.SetColor(LightCtrl.Light.LIGHT2, LightCtrl.Color.ROTATE);
            LightCtrl.SetColor(LightCtrl.Light.LIGHT1, LightCtrl.Color.ROTATE);

            // Movement
            while (!ScriptControl.GetStopLights())
            {

                LightCtrl.SetPan(LightCtrl.Light.LIGHT1, 85);
                LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, 255);
                LightCtrl.SetPan(LightCtrl.Light.LIGHT2, 85);
                LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, 255);


        
                LightCtrl.SetPan(90);
                LightCtrl.SetTilt(185);

                  

            
                LightCtrl.SetPan(LightCtrl.Light.LIGHT1, 90);
                LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, 185);
                LightCtrl.SetPan(LightCtrl.Light.LIGHT2, 85);
                LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, 255);
                   

                LightCtrl.SetPan(LightCtrl.Light.LIGHT1, 85);
                LightCtrl.SetTilt(LightCtrl.Light.LIGHT1, 255);
                LightCtrl.SetPan(LightCtrl.Light.LIGHT2, 90);
                LightCtrl.SetTilt(LightCtrl.Light.LIGHT2, 185);
                
            }
        }

    } 
}
