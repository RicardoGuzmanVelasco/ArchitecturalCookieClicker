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

}
