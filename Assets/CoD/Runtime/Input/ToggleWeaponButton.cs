using System;
using CoD.Runtime.Controller;
using CoD.Runtime.ViewAbstractions;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace CoD.Runtime.Input
{
    public class ToggleWeaponButton : MonoBehaviour
    {
        [Inject] ToggleWeapon controller;

        void Awake()
        {
            controller.Run();
        }

        void Start()
        {
            Debug.Assert(controller is not null);
            
            controller.RunForTheFirstTime();
            GetComponent<Button>().onClick.AddListener(() => controller.Run());
        }
    }
}