using System;
using CoD.Runtime.ViewAbstractions;
using UnityEngine;
using UnityEngine.UI;

namespace CoD.Runtime.View
{
    public class ToggleWeaponButton : MonoBehaviour
    {
        ToggleWeapon controller;

        void Awake()
        {
            //manera guarra. Por favor, arreglar.
            Inject(ToggleWeapon.Create(FindObjectOfType<ResourcesWeaponHUD>()));

            controller.RunForTheFirstTime();
            GetComponent<Button>().onClick.AddListener(() => controller.Run());
        }

        public void Inject(ToggleWeapon controllerToInject)
        {
            controller = controllerToInject;
        }
    }
}