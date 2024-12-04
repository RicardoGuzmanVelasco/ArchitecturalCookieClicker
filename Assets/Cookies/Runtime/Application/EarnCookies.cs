using System;
namespace Cookies.Runtime.Application
{
    public class EarnCookies
    {
        readonly CookieBox domain = new CookieBox();
        readonly CookieCounter counter;
        
        public EarnCookies(CookieBox domain, CookieCounter counter)
        {
            this.domain = domain ?? throw new ArgumentNullException(nameof(domain));
            this.counter = counter ?? throw new ArgumentNullException(nameof(counter));
        }

        public void Run(int howManyTimes)
        {
            for (var i = 0; i < howManyTimes; i++)
            {
                Run();
            }
        }
        public void Run()
        {
            domain.Add(domain.CookiesPerTime);
            counter.Print(domain.Cookies);
        }
    }
}