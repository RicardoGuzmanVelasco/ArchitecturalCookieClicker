using System;
using DataStructures;

namespace Cookies.Runtime.Application
{
    public class AutoEarnCookies
    {
        const int CURRENT_TIME_TO_AUTOEARN = 1;
        
        readonly EarnCookies earnCookies;
        readonly Timer timer;

        public AutoEarnCookies(EarnCookies earnCookies)
        {
            this.earnCookies = earnCookies;
            timer = new Timer(CURRENT_TIME_TO_AUTOEARN);
        }

        public void Run(TimeSpan howMuchHasPassed)
        {
            var ticks = timer.Tick(howMuchHasPassed);
            earnCookies.Run(ticks);
        }
    }
}