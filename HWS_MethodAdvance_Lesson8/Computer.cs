using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_MethodAdvance_Lesson8
{
    internal class Computer
    {
        public string[] allOpenFiles;
        public bool isTurnOn;


        public Computer(string[] allOpenFiles)
        {
            this.allOpenFiles = allOpenFiles;
            isTurnOn = true;
        }
        public void TurnOff()
        {
            isTurnOn = false;
            allOpenFiles = null;
            Console.WriteLine("now, computer is turn off...");
        }

        public void TurnOff(bool forceShutDown)
        {
            if (forceShutDown || (!forceShutDown && (allOpenFiles == null || allOpenFiles.Length == 0)))
                TurnOff();
        }
    }
}
