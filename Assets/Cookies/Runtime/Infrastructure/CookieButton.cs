using Cookies.Runtime.Application;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CookieButton : MonoBehaviour, CookieCounter
{
    EarnCookies controller;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(CallController);
    }

    private void CallController() 
    {
        controller.Run();
    }

    public void Print(int howMany)
    {
        GetComponentInChildren<TMP_Text>().text = howMany.ToString();
    }

    public void Inject(EarnCookies _controller)
    {
        controller = _controller;
    }
}
