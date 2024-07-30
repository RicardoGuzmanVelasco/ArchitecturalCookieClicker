using System;

namespace Cookies.Runtime.Domain
{
    public class Timer
    {
        TimeSpan elapsed = TimeSpan.Zero;
        readonly TimeSpan period;
        Action subscribed;

        public Timer(float periodInSeconds)
        {
            this.period = TimeSpan.FromSeconds(periodInSeconds);
        }
        
        
        public void Tick(TimeSpan deltaTime)
        {
            if (deltaTime > period)
                throw new NotSupportedException();
            
            elapsed += deltaTime;
            if (elapsed >= period)
            {
                elapsed -= period;
                subscribed?.Invoke();
            }
        }

        public void Subscribe(Action what)
        {
            subscribed = what;
        }
    }
}