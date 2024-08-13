using System;
using CoD.Runtime.Controller;
using UnityEngine;

namespace CoD.Runtime.Input
{
    public class ShootWhenPressLetterQ : MonoBehaviour
    {
        Shoot controller;

        void Update()
        {
            if(UnityEngine.Input.GetKeyDown(KeyCode.Q))
                controller.Run();
        }

        public void Inject(Shoot controller)
        {
            this.controller = controller;
        }
    }
}