namespace Cookies.Runtime.Application
{
    public interface CookieCounter
    {
        void Print(int howMany);
    }
    
    public class DummyCookieCounter : CookieCounter
    {
        public int LastCall { get; private set; }
        public void Print(int howMany)
        {
            LastCall = howMany;
        }
    }
}