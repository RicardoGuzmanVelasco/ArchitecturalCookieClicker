namespace Cookies.Runtime.Application
{
    public class EarnCookies
    {
        const int CookiesPerTime = 1;
        readonly CookieBox domain = new CookieBox();
        readonly CookieCounter counter;
        
        public EarnCookies(CookieCounter counter)
        {
            this.counter = counter;
        }

        public void Run()
        {
            domain.Add(CookiesPerTime);
            counter.Print(CookiesPerTime);
        }
    }
}