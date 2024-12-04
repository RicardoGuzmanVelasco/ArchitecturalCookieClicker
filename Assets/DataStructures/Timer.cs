using System;

namespace DataStructures
{
    public class Timer
    {
        public float TimePassed { get; private set; }
        public float TimeToPass { get; private set; }

        public Timer(float timeToPass)
        {
            TimeToPass = timeToPass;
        }

        public int Tick(TimeSpan delta)
        {
            var timesTicked = 0;
            
            TimePassed += (float)delta.TotalSeconds;
            while (TimePassed >= TimeToPass)
            {
                timesTicked++;
                TimePassed -= TimeToPass;
            }
            
            return timesTicked;
        }
    }
}