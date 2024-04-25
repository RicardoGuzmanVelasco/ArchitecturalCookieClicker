using Cookies.Runtime.Application;
using UnityEngine;
using UnityEngine.UI;

public class CookieButton : MonoBehaviour
{
    readonly EarnCookies earnCookies = new EarnCookies(null);
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(CallController);
    }

    private void CallController() 
    {
        earnCookies.Run();
    }
}
