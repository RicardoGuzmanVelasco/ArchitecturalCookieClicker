using System;
using Cookies.Runtime.Application;
using UnityEngine;

namespace Cookies.Runtime.Infrastructure
{
    public class TimePassage : MonoBehaviour
    {
        AutoEarnCookies controller;

        public void Inject(EarnCookies earnCookies)
        {
            controller = new AutoEarnCookies(earnCookies);
        }

        void Update()
        {
            controller.Run(TimeSpan.FromSeconds(Time.deltaTime));
        }
    }
}