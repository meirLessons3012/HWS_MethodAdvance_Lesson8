using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_MethodAdvance_Lesson8
{
    internal class SmartComp : Computer
    {
        public string[] filesInCache;
        public SmartComp(string[] allOpenFiles) : base(allOpenFiles)
        {
        }

        public void TurnOff(bool forceShutDown, bool keepFilesInCache)
        {
            if (keepFilesInCache && allOpenFiles != null && allOpenFiles.Length > 0)
                filesInCache = allOpenFiles;
            TurnOff(forceShutDown);
            //if (forceShutDown || (!forceShutDown && (allOpenFiles == null || allOpenFiles.Length == 0)))
            //{
            //    TurnOff();
            //}
        }
    }
}
