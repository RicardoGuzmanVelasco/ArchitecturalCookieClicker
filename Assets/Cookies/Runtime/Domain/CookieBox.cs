using System;
public class CookieBox
{
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
        var cookiesBefore = Cookies;
        if (cookiesToSubtract <= 0) throw new ArgumentOutOfRangeException(nameof(cookiesToSubtract));

        Cookies -= cookiesToSubtract;
        if (Cookies == cookiesBefore) throw new ArgumentException("no se han restado las galletas");
    }
}
