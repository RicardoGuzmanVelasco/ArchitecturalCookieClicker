using Cookies.Runtime.Application;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PurchasePowerupButton : MonoBehaviour, CookieMultiplier
{
    PurchasePowerup controller;
    string initialTextString;
    private void Awake()
    {
        initialTextString = GetComponentInChildren<TMP_Text>().text;
    }

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(CallController);
    }

    private void CallController()
    {
        controller.Run();
    }

    public void Inject(PurchasePowerup _controller)
    {
        controller = _controller;
    }

    public void Print(int howMuch)
    {
        GetComponentInChildren<TMP_Text>().text = initialTextString + "(+ " + howMuch.ToString() + ")";
    }
}
