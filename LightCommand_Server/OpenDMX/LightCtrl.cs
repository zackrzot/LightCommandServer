using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightCommand_Server
{
    public static class LightCtrl
    {

        public static void AllOff()
        {
            for (int i = 1; i <= 20; i++)
                OpenDMX.setDmxValue(i, 0);
            OpenDMX.writeData();
        }

        public enum Light
        {
            LIGHT1,
            LIGHT2
        }

        public enum Color
        {
            WHITE,
            RED,
            ORANGE,
            YELLOW,
            LGREEN,
            DBLUE,
            MAGENTA,
            LBLUE,
            PINK,
            ROTATE
        }

        public enum Gobo
        {
            OPEN,
            SWIRL,
            CIRCLE,
            SQUARE,
            DOTS,
            LINE,
            OCT,
            SWIRLCROSS,
            STARS,
            ROTATE
        }

        public static void SetStrobe(Light l, Boolean on)
        {
            if (on)
                OpenDMX.setDmxValue(getChan(l, 3), 131);
            else
                OpenDMX.setDmxValue(getChan(l, 3), 0);
  
            OpenDMX.writeData();
        }

        public static void SetGobo(Light l, Gobo g)
        {
            switch (g)
            {
                case Gobo.OPEN:
                    OpenDMX.setDmxValue(getChan(l, 5), 0);
                    break;
                case Gobo.SWIRL:
                    OpenDMX.setDmxValue(getChan(l, 5), 15);
                    break;
                case Gobo.CIRCLE:
                    OpenDMX.setDmxValue(getChan(l, 5), 30);
                    break;
                case Gobo.SQUARE:
                    OpenDMX.setDmxValue(getChan(l, 5), 45);
                    break;
                case Gobo.DOTS:
                    OpenDMX.setDmxValue(getChan(l, 5), 60);
                    break;
                case Gobo.LINE:
                    OpenDMX.setDmxValue(getChan(l, 5), 75);
                    break;
                case Gobo.OCT:
                    OpenDMX.setDmxValue(getChan(l, 5), 90);
                    break;
                case Gobo.SWIRLCROSS:
                    OpenDMX.setDmxValue(getChan(l, 5), 105);
                    break;
                case Gobo.STARS:
                    OpenDMX.setDmxValue(getChan(l, 5), 120);
                    break;
                case Gobo.ROTATE:
                    OpenDMX.setDmxValue(getChan(l, 5), 200);
                    break;
            }

            OpenDMX.writeData();
        }

        public static void SetColor(Light l, Color c)
        {
            switch (c)
            {
                case Color.WHITE:
                    OpenDMX.setDmxValue(getChan(l, 4), 0);
                    break;
                case Color.RED:
                    OpenDMX.setDmxValue(getChan(l, 4), 15);
                    break;
                case Color.ORANGE:
                    OpenDMX.setDmxValue(getChan(l, 4), 30);
                    break;
                case Color.YELLOW:
                    OpenDMX.setDmxValue(getChan(l, 4), 45);
                    break;
                case Color.LGREEN:
                    OpenDMX.setDmxValue(getChan(l, 4), 60);
                    break;
                case Color.DBLUE:
                    OpenDMX.setDmxValue(getChan(l, 4), 75);
                    break;
                case Color.MAGENTA:
                    OpenDMX.setDmxValue(getChan(l, 4), 90);
                    break;
                case Color.LBLUE:
                    OpenDMX.setDmxValue(getChan(l, 4), 105);
                    break;
                case Color.PINK:
                    OpenDMX.setDmxValue(getChan(l, 4), 120);
                    break;
                case Color.ROTATE:
                    OpenDMX.setDmxValue(getChan(l, 4), 193);
                    break;
            }

            OpenDMX.writeData();
        }


        public static void SetPan(Light l, Int32 deg)
        {
            if (deg > 255 || deg < 0)
                return;

            OpenDMX.setDmxValue(getChan(l, 6), Convert.ToByte(deg));
            OpenDMX.writeData();
        }


        public static void SetPanFine(Light l, Int32 deg)
        {
            if (deg > 255 || deg < 0)
                return;

            OpenDMX.setDmxValue(getChan(l, 7), Convert.ToByte(deg));
            OpenDMX.writeData();
        }

        public static void SetTilt(Light l, Int32 deg)
        {
            if (deg > 255 || deg < 0)
                return;

            OpenDMX.setDmxValue(getChan(l, 8), Convert.ToByte(deg));
            OpenDMX.writeData();
        }

        public static void SetTilt(Int32 deg)
        {
            if (deg > 255 || deg < 0)
                return;

            OpenDMX.setDmxValue(getChan(Light.LIGHT1, 8), Convert.ToByte(deg));
            OpenDMX.setDmxValue(getChan(Light.LIGHT2, 8), Convert.ToByte(deg));
            OpenDMX.writeData();
        }

        public static void SetPan(Int32 deg)
        {
            if (deg > 255 || deg < 0)
                return;

            OpenDMX.setDmxValue(getChan(Light.LIGHT1, 7), Convert.ToByte(deg));
            OpenDMX.setDmxValue(getChan(Light.LIGHT2, 7), Convert.ToByte(deg));
            OpenDMX.writeData();
        }

        public static void SetTiltFine(Light l, Int32 deg)
        {
            if (deg > 255 || deg < 0)
                return;

            OpenDMX.setDmxValue(getChan(l, 9), Convert.ToByte(deg));
            OpenDMX.writeData();
        }

        private static int getChan(Light l, int baseInt)
        {
            int ret = 0;
            if (l == Light.LIGHT1)
                ret = baseInt;
            else
                ret = baseInt + 9;
            //Logger.Log(ret.ToString());
            return ret;
        }

        public static void LightOnOff(Light l, Boolean on) 
        {
            if (on)
            {
                OpenDMX.setDmxValue(getChan(l, 1), 255);
                OpenDMX.setDmxValue(getChan(l, 2), 255);
                OpenDMX.setDmxValue(getChan(l, 3), 255);
            }
            else
            {
                OpenDMX.setDmxValue(getChan(l, 1), 0);
                OpenDMX.setDmxValue(getChan(l, 2), 0);
                OpenDMX.setDmxValue(getChan(l, 3), 0);
            }
            OpenDMX.writeData();
        }

    }
}
