using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Module_12
{
    class PowerInformaion
    {
        const int SystemPowerInformation = 12;
        const uint STATUS_SUCCESS = 0;

        struct SYSTEM_POWER_INFORMATION
        {
            public uint MaxIdlenessAllowed;
            public uint Idleness;
            public uint TimeRemaining;
            public byte CoolingMode;
        }

        [DllImport("powrprof.dll")]
        static extern uint CallNtPowerInformation(
            int InformationLevel,
            IntPtr lpInputBuffer,
            int nInputBufferSize,
            out SYSTEM_POWER_INFORMATION spi,
            int nOutputBufferSize
        );


        // тут вопрос возник по функции на MSDN написанно что 
        // The lpInBuffer parameter must be NULL; otherwise, the function returns ERROR_INVALID_PARAMETER.
        // но припопытки передать туда null студия ругается. А если как сейчас сделнно первые 2 функции возращают 0, 
        // не 0 возращает SystemPowerInformatio. правильно ли я использовал данные функции? я так понимаю CallNtPowerInformation и SetSuspendState на с++ написанны


        public static void LastSleepTime()
        {
            SYSTEM_POWER_INFORMATION spi;
            uint retval = CallNtPowerInformation(15, IntPtr.Zero, 0, out spi,
                Marshal.SizeOf(typeof(SYSTEM_POWER_INFORMATION))
            );
            if (retval == STATUS_SUCCESS)
                Console.WriteLine(spi.TimeRemaining);

        }

        public static void LastWakeTime()
        {
            SYSTEM_POWER_INFORMATION spi;
            uint retval = CallNtPowerInformation(14, IntPtr.Zero, 0, out spi,
                Marshal.SizeOf(typeof(SYSTEM_POWER_INFORMATION))
            );
            if (retval == STATUS_SUCCESS)
                Console.WriteLine(spi.TimeRemaining);
        }

        public static void SystemBatteryState()
        {
            SYSTEM_POWER_INFORMATION spi;
            uint retval = CallNtPowerInformation(5, IntPtr.Zero, 0, out spi,
                Marshal.SizeOf(typeof(SYSTEM_POWER_INFORMATION))
            );
            if (retval == STATUS_SUCCESS)
                Console.WriteLine(spi.TimeRemaining);
        }

        public static void SystemPowerInformatio()
        {
            SYSTEM_POWER_INFORMATION spi;
            uint retval = CallNtPowerInformation(12, IntPtr.Zero, 0, out spi,
                Marshal.SizeOf(typeof(SYSTEM_POWER_INFORMATION))
            );
            if (retval == STATUS_SUCCESS)
                Console.WriteLine(spi.TimeRemaining);
        }
    }
}



