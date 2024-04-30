using Cookies.Runtime.Application;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PurchasePowerupButton : MonoBehaviour, CookieMultiplier
{
    CookieBox domain;
    PowerUp powerUpDomain;
    PurchasePowerup controller;
    string initialTextString;
    private void Awake()
    {
        initialTextString = GetComponentInChildren<TMP_Text>().text;
    }

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(CallController);
        Print(domain.CookiesPerTime, powerUpDomain.Price);
    }

    private void CallController()
    {
        controller.Run();
    }

    public void Inject(PurchasePowerup _controller, CookieBox _domain, PowerUp _powerUpDomain)
    {
        controller = _controller;
        domain = _domain;
        powerUpDomain = _powerUpDomain;
    }

    public void Print(int howMuch, int price)
    {
        GetComponentInChildren<TMP_Text>().text = initialTextString + "(+ " + howMuch.ToString() + ")" + "\n(" + price.ToString() + ")";
    }
}
