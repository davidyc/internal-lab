using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Module_12
{
    class SleepOrHibernation
    {
        [DllImport("Powrprof.dll", SetLastError = true)]
        static extern bool SetSuspendState(bool hibernate, bool forceCritical, bool disableWakeEvent);

        public static void GoToSleep()
        {
            SetSuspendState(false, false, false);
        }
        

        public static void Hibernation()
        {
            SetSuspendState(false, false, false);
        }
    }

    //https://docs.microsoft.com/ru-ru/windows/desktop/api/winbase/nf-winbase-setsystempowerstate
    //https://docs.microsoft.com/en-us/windows/desktop/api/powrprof/nf-powrprof-setsuspendstate


}

