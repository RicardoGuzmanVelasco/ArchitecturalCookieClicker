using System;
using Cookies.Runtime.Application;
using UnityEngine;

namespace Cookies.Runtime.Infrastructure
{
    public class TimePassage : MonoBehaviour
    {
        AutoEarn controller;
        
        public void Inject(EarnCookies controller)
        {
            this.controller = new AutoEarn(controller);
        }

        void Update()
        {
            controller.Tick(Time.deltaTime);
        }
    }
}