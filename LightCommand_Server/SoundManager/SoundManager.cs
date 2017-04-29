using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace LightCommand_Server
{
    public static class SoundManager
    {

        public static SoundPlayer simpleSound;

        public enum AudioFile
        {
            XFILES,
            AIRHORN,
            BREAK3,
            MILLIONAIRE,
            SCRATCH,
            SUCK,
            SUSPENSE,
            TRANCE,
            TRIPLE,
            USA
        }




        public static void StartSound(AudioFile af)
        {
            simpleSound = null;

            string curDir = Path.Combine(Environment.CurrentDirectory, "AudioResources\\");

            Boolean loop = false;


            switch (af) 
            { 
                case AudioFile.XFILES:
                simpleSound = new SoundPlayer(curDir + "xFiles.wav");
                loop = true;
                break;
                case AudioFile.AIRHORN:
                simpleSound = new SoundPlayer(curDir + "airhorn.wav");
                loop = false;
                break;
            case AudioFile.BREAK3:
                simpleSound = new SoundPlayer(curDir + "break3.wav");
                loop = true;
                break;
            case AudioFile.MILLIONAIRE:
                simpleSound = new SoundPlayer(curDir + "millionaire.wav");
                loop = false;
                break;
            case AudioFile.SCRATCH:
                simpleSound = new SoundPlayer(curDir + "scratch.wav");
                loop = false;
                break;
            case AudioFile.SUCK:
                simpleSound = new SoundPlayer(curDir + "suck.wav");
                loop = false;
                break;
            case AudioFile.SUSPENSE:
                simpleSound = new SoundPlayer(curDir + "suspense.wav");
                loop = true;
                break;
            case AudioFile.TRANCE:
                simpleSound = new SoundPlayer(curDir + "trance.wav");
                loop = true;
                break;
            case AudioFile.TRIPLE:
                simpleSound = new SoundPlayer(curDir + "triple.wav");
                loop = false;
                break;
            case AudioFile.USA:
                simpleSound = new SoundPlayer(curDir + "usa.wav");
                loop = true;
                break;
            }








            if (simpleSound != null)
            {
                if(loop)
                    simpleSound.PlayLooping();
                else
                    simpleSound.Play();
            }
            else
                Logger.Log("No sounds to play for this sequence.");


        }


        public static void StopSound()
        {
            if(simpleSound != null)
                simpleSound.Stop();

        }


    }
}
