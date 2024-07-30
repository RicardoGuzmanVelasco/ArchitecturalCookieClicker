using System;
using System.Linq;
using Cookies.Runtime.Application;
using Cookies.Runtime.Domain;
using UnityEngine;

namespace Cookies.Runtime.Infrastructure
{
    public class Dependencies : MonoBehaviour
    {
        public EarnCookies EarnCookies { get; private set; }

        void Awake()
        {
            var cookieCounter = FindObjectOfType<CookieButton>();
            EarnCookies = new EarnCookies(new CookieBox(), cookieCounter);
            
            FindObjectsOfType<CookieButton>().Single().Inject(EarnCookies);
            FindObjectOfType<TimePassage>().Inject(EarnCookies);
        }
    }
}