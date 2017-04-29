using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LightCommand_Server
{
    public enum LightStatus
    {
        IDLE,
        RUNNING,
        LOOPING
    }

    public enum LightScript
    {
        BREAK1,
        BREAK2,
        BREAK3,
        FINAL1,
        FINAL2,
        FINAL3,
        TRIPLE,
        MILLIONARE,
        XFILES,
        TRANCE,
        YOUSUCK,
        SCRATCH,
        FRONTR,
        FRONTL,
        MIDDLER,
        MIDDLEL,
        BACKR,
        BACKL,
        AIRHORN,
        SUSPENSE,
        USA
    }

    public static class ScriptControl
    {
        private static LightStatus _lightStatus = LightStatus.IDLE;
        private static Boolean _stopLights = false;

        private static Object _lockLightStatus = new Object();
        private static Object _lockStopLights = new Object();

        public static LightStatus CurrentLightStatus
        {
            get
            {
                lock (_lockLightStatus)
                {
                    return _lightStatus;
                }
            }
            set
            {
                lock (_lockLightStatus)
                {
                    _lightStatus = value;
                }
            }
        }
        private static Boolean stopLights
        {
            get
            {
                lock (_lockStopLights)
                {
                    return _stopLights;
                }
            }
            set
            {
                lock (_lockStopLights)
                {
                    _stopLights = value;
                }
            }
        }


        public static void RunScript(LightScript script)
        {
            // Check if lights are already running
            if (ScriptControl.CurrentLightStatus != LightStatus.IDLE)
            {
                Logger.Log("Unable to run script, sequence active.");
                return;
            }

            ResetStopLightState();

            switch (script)
            {
                case LightScript.BREAK1:
                    Scripts.BREAK1 break1 = new Scripts.BREAK1();
                    Thread break1Thread = new Thread(break1.StartSequence);
                    break1Thread.Start();
                    break;
                case LightScript.BREAK2:
                    Scripts.BREAK2 break2 = new Scripts.BREAK2();
                    Thread break2Thread = new Thread(break2.StartSequence);
                    break2Thread.Start();
                    break;
                case LightScript.BREAK3:
                    SoundManager.StartSound(SoundManager.AudioFile.BREAK3);
                    Scripts.BREAK3 break3 = new Scripts.BREAK3();
                    Thread break3Thread = new Thread(break3.StartSequence);
                    break3Thread.Start();
                    break;
                case LightScript.FINAL1:
                    Scripts.FINAL1 final1 = new Scripts.FINAL1();
                    Thread final1Thread = new Thread(final1.StartSequence);
                    final1Thread.Start();
                    break;
                case LightScript.FINAL2:
                    Scripts.FINAL2 final2 = new Scripts.FINAL2();
                    Thread final2Thread = new Thread(final2.StartSequence);
                    final2Thread.Start();
                    break;
                case LightScript.FINAL3:
                    Scripts.FINAL3 final3 = new Scripts.FINAL3();
                    Thread final3Thread = new Thread(final3.StartSequence);
                    final3Thread.Start();
                    break;
                case LightScript.TRIPLE:
                    SoundManager.StartSound(SoundManager.AudioFile.TRIPLE);
                    Scripts.TRIPLE triple = new Scripts.TRIPLE();
                    Thread tripleThread = new Thread(triple.StartSequence);
                    tripleThread.Start();
                    break;
                case LightScript.MILLIONARE:
                    SoundManager.StartSound(SoundManager.AudioFile.MILLIONAIRE);
                    Scripts.MILLIONARE millionare = new Scripts.MILLIONARE();
                    Thread millionareThread = new Thread(millionare.StartSequence);
                    millionareThread.Start();
                    break;
                case LightScript.XFILES:
                    SoundManager.StartSound(SoundManager.AudioFile.XFILES);
                    Scripts.XFILES xfiles = new Scripts.XFILES();
                    Thread xfilesThread = new Thread(xfiles.StartSequence);
                    xfilesThread.Start();
                    break;
                case LightScript.TRANCE:
                    SoundManager.StartSound(SoundManager.AudioFile.TRANCE);
                    Scripts.TRANCE trance = new Scripts.TRANCE();
                    Thread tranceThread = new Thread(trance.StartSequence);
                    tranceThread.Start();
                    break;
                case LightScript.YOUSUCK:
                    SoundManager.StartSound(SoundManager.AudioFile.SUCK);
                    Scripts.YOUSUCK yousuck = new Scripts.YOUSUCK();
                    Thread yousuckThread = new Thread(yousuck.StartSequence);
                    yousuckThread.Start();
                    break;
                case LightScript.SCRATCH:
                    SoundManager.StartSound(SoundManager.AudioFile.SCRATCH);
                    Scripts.SCRATCH scratch = new Scripts.SCRATCH();
                    Thread scratchThread = new Thread(scratch.StartSequence);
                    scratchThread.Start();
                    break;
                case LightScript.FRONTR:
                    Scripts.FRONTR frontr = new Scripts.FRONTR();
                    Thread frontrThread = new Thread(frontr.StartSequence);
                    frontrThread.Start();
                    break;
                case LightScript.FRONTL:
                    Scripts.FRONTL frontl = new Scripts.FRONTL();
                    Thread frontlThread = new Thread(frontl.StartSequence);
                    frontlThread.Start();
                    break;
                case LightScript.MIDDLER:
                    Scripts.MIDDLER middler = new Scripts.MIDDLER();
                    Thread middlerThread = new Thread(middler.StartSequence);
                    middlerThread.Start();
                    break;
                case LightScript.MIDDLEL:
                    Scripts.MIDDLEL middlel = new Scripts.MIDDLEL();
                    Thread middlelThread = new Thread(middlel.StartSequence);
                    middlelThread.Start();
                    break;
                case LightScript.BACKR:
                    Scripts.BACKR backr = new Scripts.BACKR();
                    Thread backrThread = new Thread(backr.StartSequence);
                    backrThread.Start();
                    break;
                case LightScript.BACKL:
                    Scripts.BACKL backl = new Scripts.BACKL();
                    Thread backlThread = new Thread(backl.StartSequence);
                    backlThread.Start();
                    break;
                case LightScript.AIRHORN:
                    SoundManager.StartSound(SoundManager.AudioFile.AIRHORN);
                    Scripts.AIRHORN airhorn = new Scripts.AIRHORN();
                    Thread airhornThread = new Thread(airhorn.StartSequence);
                    airhornThread.Start();
                    break;
                case LightScript.SUSPENSE:
                    SoundManager.StartSound(SoundManager.AudioFile.SUSPENSE);
                    Scripts.SUSPENSE suspense = new Scripts.SUSPENSE();
                    Thread suspenseThread = new Thread(suspense.StartSequence);
                    suspenseThread.Start();
                    break;
                case LightScript.USA:
                    SoundManager.StartSound(SoundManager.AudioFile.USA);
                    Scripts.USA usa = new Scripts.USA();
                    Thread usaThread = new Thread(usa.StartSequence);
                    usaThread.Start();
                    break;
                default:
                    Logger.Log("Requested script not mapped: " + script.ToString());
                    break;
            }
        }


        public static void StopLights()
        {
            SoundManager.StopSound();
            Logger.Log("Stopping lights.");
            stopLights = true;
            LightCtrl.AllOff();
        }

        public static Boolean GetStopLights()
        {
            if (stopLights)
                Logger.Log("its time to stop");
            return stopLights;
        }

        public static void ResetStopLightState()
        {
            stopLights = false;
        }

    }


}
