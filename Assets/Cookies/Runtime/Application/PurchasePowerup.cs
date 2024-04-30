using System;

namespace Cookies.Runtime.Application
{
    public class PurchasePowerup
    {
        readonly CookieBox domain;
        readonly CookieCounter counter;
        readonly CookieMultiplier multiplier;
        readonly PowerUp powerUpDomain;

        public PurchasePowerup(CookieBox domain, PowerUp powerUpDomain, CookieCounter counter, CookieMultiplier multiplier)
        {
            this.domain = domain ?? throw new ArgumentNullException(nameof(domain));
            this.powerUpDomain = powerUpDomain ?? throw new ArgumentNullException(nameof(powerUpDomain));
            this.counter = counter ?? throw new ArgumentNullException(nameof(counter));
            this.multiplier = multiplier ?? throw new ArgumentNullException(nameof(multiplier));
        }

        public void Run()
        {
            if (!domain.IsAffordable(powerUpDomain.Price)) return;
            domain.Subtract(powerUpDomain.Price);
            counter.Print(domain.Cookies);
            domain.DoubleMultiplicator();
            
            powerUpDomain.AddLevel();
            multiplier.Print(domain.CookiesPerTime, powerUpDomain.Price);
        }
    }
}