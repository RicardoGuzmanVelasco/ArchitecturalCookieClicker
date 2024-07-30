using System;
using Cookies.Runtime.Domain;

namespace Cookies.Runtime.Application
{
    public class AutoEarn
    {
        readonly Timer timer;
        
        public AutoEarn(EarnCookies delegated)
        {
            this.timer = new Timer(AutoEarnRatio.DefaultPorAhora);
            timer.Subscribe(delegated.Run);
        }

        public void Tick(float deltaTime)
        {
            timer.Tick(TimeSpan.FromSeconds(deltaTime));
        }
    }
}