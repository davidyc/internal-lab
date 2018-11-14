using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Licenzi : ISubstruct
    {
        int period;   
        Countdown cd;

        public Licenzi(int period)
        {          
            this.period = period;
        }

        public Licenzi(int period, Countdown countdown) : this(period)
        {
            this.cd = countdown;
        }

        /// <summary>
        /// Осталось времени по лизензии
        /// </summary>
        public void LicenziEnd()
        {
            Console.WriteLine(period + " years left license");
            period--;
            if(period < 0)
            {
                DelOnEvent();
            }
        }

        /// <summary>
        /// Substruction on event
        /// </summary>
        /// <param name="act"></param>
        public void SubOnEvent()
        {
            if (period > 0)
            {
                cd.SendMessageAboutEvent += LicenziEnd;
            }
           
        }

        /// <summary>
        ///  Отписать от события
        /// </summary>
        /// <param name="act"></param>
        public void DelOnEvent()
        {
            cd.SendMessageAboutEvent -= LicenziEnd;
            Console.WriteLine("License ended");
        }

    }
}
