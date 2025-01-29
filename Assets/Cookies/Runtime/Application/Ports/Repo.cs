namespace Cookies.Runtime.Application
{
    public interface Repo
    {
        void Commit(int cookieCount, int powerupLevel);
        void Commit(int cookieCount);
    }
}