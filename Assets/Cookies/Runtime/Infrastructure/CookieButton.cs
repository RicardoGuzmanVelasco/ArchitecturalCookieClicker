using Cookies.Runtime.Application;
using Cookies.Runtime.Domain;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Cookies.Runtime.Infrastructure
{
    public class CookieButton : MonoBehaviour, CookieCounter
    {
        public EarnCookies earnCookies;
        
        void Awake()
        {
            GetComponent<Button>().onClick.AddListener(CallController);
        }

        public void Inject(EarnCookies earnCookies)
        {
            this.earnCookies = earnCookies;
        }

        void CallController()
        {
            earnCookies.Run();
        }

        public void ShowCookies(int howMany)
        {
            GetComponentInChildren<TMP_Text>().text = howMany + " galletas";
        }
    }
}