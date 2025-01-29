namespace Cookies.Runtime.Application
{
    public interface CookieCounter
    {
        void Print(int howMany);
    }
    
    public class DummyCookieCounter : CookieCounter
    {
        public void Print(int howMany)
        {
            // Do nothing
        }
    }
}