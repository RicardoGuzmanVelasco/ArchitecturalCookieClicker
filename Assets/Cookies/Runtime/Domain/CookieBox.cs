using System;
public class CookieBox
{
    public int Cookies { get; private set; }

    public void Add(int cookiesToAdd)
    {
        if (cookiesToAdd <= 0) throw new ArgumentOutOfRangeException(nameof(cookiesToAdd));

        Cookies += cookiesToAdd;
    }

}
