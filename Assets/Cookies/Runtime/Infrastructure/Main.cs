using Cookies.Runtime.Application;
using UnityEngine;

public class Main : MonoBehaviour
{
    private void Awake()
    {
        CookieBox cookieBox = new CookieBox();
        CookieButton counter = FindFirstObjectByType<CookieButton>();
        EarnCookies earnCookies = new EarnCookies(cookieBox, counter);
        PurchasePowerup purchasePowerup = new PurchasePowerup(cookieBox, counter);
        FindAnyObjectByType<CookieButton>().Inject(earnCookies);
        FindAnyObjectByType<PurchasePowerupButton>().Inject(purchasePowerup);
    }
}
