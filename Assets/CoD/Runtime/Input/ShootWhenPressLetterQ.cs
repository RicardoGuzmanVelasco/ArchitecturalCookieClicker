using System;
using CoD.Runtime.Controller;
using UnityEngine;
using Zenject;

namespace CoD.Runtime.Input
{
    public class ShootWhenPressLetterQ : MonoBehaviour
    {
        [Inject] Shoot controller;

        void Update()
        {
            if(UnityEngine.Input.GetKeyDown(KeyCode.Q))
                controller.Run();
        }
    }
}