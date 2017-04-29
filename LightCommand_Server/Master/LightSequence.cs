using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightCommand_Server
{
    public abstract class LightSequence
    {
        public LightSequence()
        {
        }

        // Variables
        private Boolean _loop = false;
        private String _name = null;

        private Object _lockLoop = new Object();
        private Object _lockName = new Object();

        public Boolean Loop
        {
            get
            {
                lock (_lockLoop)
                {
                    return _loop;
                }
            }
            set
            {
                lock (_lockLoop)
                {
                    _loop = value;
                }
            }
        }
        public String Name
        {
            get
            {
                lock (_lockName)
                {
                    return _name;
                }
            }
            set
            {
                lock (_lockName)
                {
                    _name = value;
                }
            }
        }

        public void StartSequence()
        {
            Logger.Log("Starting sequence for script: " + this.Name + " Loop: " + this.Loop.ToString());
            if (_loop)
            {
                Logger.SetLightStatus(LightStatus.LOOPING);

                while (!ScriptControl.GetStopLights())
                {
                    Sequence();
                }
            }
            else
            {
                Logger.SetLightStatus(LightStatus.RUNNING);
                Sequence();
            }

            Logger.Log("Sequence " + this.Name + " ended.");
            Logger.SetLightStatus(LightStatus.IDLE);
        }

        public virtual void Sequence() { }


    }
}
