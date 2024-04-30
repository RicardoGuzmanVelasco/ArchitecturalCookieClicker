using Cookies.Runtime.Application;
using UnityEngine;

public class Main : MonoBehaviour
{
    private void Awake()
    {
        CookieBox cookieBox = new CookieBox();
        PowerUp powerUp = new PowerUp();
        CookieButton counter = FindFirstObjectByType<CookieButton>();
        CookieMultiplier multiplier = FindFirstObjectByType<PurchasePowerupButton>();
        EarnCookies earnCookies = new EarnCookies(cookieBox, counter);
        PurchasePowerup purchasePowerup = new PurchasePowerup(cookieBox, powerUp, counter, multiplier);
        FindAnyObjectByType<CookieButton>().Inject(earnCookies);
        FindAnyObjectByType<PurchasePowerupButton>().Inject(purchasePowerup, cookieBox);
    }
}
