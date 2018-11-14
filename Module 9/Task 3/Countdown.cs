using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_3
{
    public class Countdown
    {
        int waittime;
        public event Action SendMessageAboutEvent;

        public Countdown(int time)
        {
            waittime = time; //seconds
        }

        /// <summary>
        /// StartTimerEvent
        /// </summary>
        public void EventTime()
        {
            while (true)
            {
                Thread.Sleep(waittime*1000);

                Console.WriteLine("A year has passed");

                if (SendMessageAboutEvent != null)
                {
                    SendMessageAboutEvent();
                }
                else
                {
                    Console.WriteLine("No scheduled event");
                }
            }
        }


    }

}
