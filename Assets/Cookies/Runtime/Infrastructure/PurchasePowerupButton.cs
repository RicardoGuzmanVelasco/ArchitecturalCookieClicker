using Cookies.Runtime.Application;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PurchasePowerupButton : MonoBehaviour, CookieMultiplier
{
    CookieBox domain;
    PurchasePowerup controller;
    string initialTextString;
    private void Awake()
    {
        initialTextString = GetComponentInChildren<TMP_Text>().text;
    }

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(CallController);
        Print(domain.CookiesPerTime);
    }

    private void CallController()
    {
        controller.Run();
    }

    public void Inject(PurchasePowerup _controller, CookieBox _domain)
    {
        controller = _controller;
        domain = _domain;
    }

    public void Print(int howMuch)
    {
        GetComponentInChildren<TMP_Text>().text = initialTextString + "(+ " + howMuch.ToString() + ")";
    }
}
