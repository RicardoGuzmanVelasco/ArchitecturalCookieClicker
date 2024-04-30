namespace Cookies.Runtime.Application
{
    public interface CookieCounter
    {
        void Print(int howMany);
    }

    public interface CookieMultiplier
    {
        void Print(int howMuch, int price);
    }
}