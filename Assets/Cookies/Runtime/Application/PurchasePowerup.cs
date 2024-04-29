using System;

namespace Cookies.Runtime.Application
{
    public class PurchasePowerup
    {
        const int PowerupPrice = 5;
        
        readonly CookieBox domain;
        readonly CookieCounter counter;
        readonly CookieMultiplier multiplier;

        public PurchasePowerup(CookieBox domain, CookieCounter counter, CookieMultiplier multiplier)
        {
            this.domain = domain ?? throw new ArgumentNullException(nameof(domain));
            this.counter = counter ?? throw new ArgumentNullException(nameof(counter));
            this.multiplier = multiplier ?? throw new ArgumentNullException(nameof(multiplier));
        }

        public void Run()
        {
            if (!domain.IsAffordable(PowerupPrice)) return;
            domain.Subtract(PowerupPrice);
            counter.Print(domain.Cookies);
            domain.DoubleMultiplicator();
            multiplier.Print(domain.CookiesPerTime);
        }
    }
}