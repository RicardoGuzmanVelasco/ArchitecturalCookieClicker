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
            controller = ToggleWeapon.Create(FindObjectOfType<ResourcesWeaponHUD>());

            controller.Run();
            controller.Run();
            GetComponent<Button>().onClick.AddListener(() => controller.Run());
        }
    }
}