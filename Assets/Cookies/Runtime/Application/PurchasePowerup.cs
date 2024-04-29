using System;

namespace Cookies.Runtime.Application
{
    public class PurchasePowerup
    {
        const int PowerupPrice = 5;
        
        readonly CookieBox domain;
        readonly CookieCounter counter;

        public PurchasePowerup(CookieBox domain, CookieCounter counter)
        {
            this.domain = domain ?? throw new ArgumentNullException(nameof(domain));
            this.counter = counter ?? throw new ArgumentNullException(nameof(counter));
        }

        public void Run()
        {
            domain.Subtract(PowerupPrice);
            counter.Print(domain.Cookies);
        }
    }
}