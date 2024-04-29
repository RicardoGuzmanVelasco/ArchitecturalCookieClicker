using System;
public class CookieBox
{
    public int CookiesPerTime { get; private set; } = 1;
    public int Cookies { get; private set; }

    public void Add(int cookiesToAdd)
    {
        var cookiesBefore = Cookies;
        if (cookiesToAdd <= 0) throw new ArgumentOutOfRangeException(nameof(cookiesToAdd));

        Cookies += cookiesToAdd;
        if (Cookies == cookiesBefore) throw new ArgumentException("no se han añadido las galletas");
    }

    public void Subtract(int cookiesToSubtract)
    {
        if (Cookies < cookiesToSubtract) throw new InvalidOperationException("No te puedes endeudar de galletas");
        var cookiesBefore = Cookies;
        if (cookiesToSubtract <= 0) throw new ArgumentOutOfRangeException(nameof(cookiesToSubtract));

        Cookies -= cookiesToSubtract;
        if (Cookies == cookiesBefore) throw new ArgumentException("no se han restado las galletas");
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
