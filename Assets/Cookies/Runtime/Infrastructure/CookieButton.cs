using Cookies.Runtime.Application;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CookieButton : MonoBehaviour, CookieCounter
{
    EarnCookies earnCookies;
    void Awake()
    {
        earnCookies = new EarnCookies(this);
    }
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(CallController);
    }

    private void CallController() 
    {
        earnCookies.Run();
    }

    public void Print(int howMany)
    {
        GetComponentInChildren<TMP_Text>().text = howMany.ToString();
    }
}
