using System;
public class CookieBox
{
    public int CookiesPerTime { get; private set; } = 1;
    public int Cookies { get; private set; }

    public void Add(int cookiesToAdd)
    {
        if (cookiesToAdd <= 0) throw new ArgumentOutOfRangeException(nameof(cookiesToAdd));
        Cookies += cookiesToAdd;
    }

    public void Subtract(int cookiesToSubtract)
    {
        if (Cookies < cookiesToSubtract) throw new InvalidOperationException("No te puedes endeudar de galletas");
        Cookies -= cookiesToSubtract;
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
