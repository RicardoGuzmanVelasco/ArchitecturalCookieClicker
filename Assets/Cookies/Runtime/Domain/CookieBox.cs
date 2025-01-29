using System;

public class CookieBox
{
    public TimeSpan AutoearnRatio { get; private set; } = TimeSpan.FromSeconds(1);
    public int CookiesPerTime { get; private set; } = 1;
    public int Cookies => cookies.Current;

    Container cookies;

    public CookieBox() : this(20) { }
    
    public CookieBox(int capacity)
    {
        this.cookies = new Container(capacity);
    }

    public void Add(int cookiesToAdd)
    {
        cookies.Add(cookiesToAdd);
    }

    public void Subtract(int cookiesToSubtract)
    {
        cookies.Subtract(cookiesToSubtract);
    }

    public void DoubleMultiplicator()
    {
        CookiesPerTime *= 2;
    }

    public bool IsAffordable(int _howMany)
    {
        return Cookies >= _howMany;
    }
}