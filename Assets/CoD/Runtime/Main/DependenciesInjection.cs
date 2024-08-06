using CoD.Runtime.Controller;
using CoD.Runtime.Input;
using CoD.Runtime.Presentation;
using UnityEngine;

namespace CoD.Runtime.Main
{
    public class DependenciesInjection : MonoBehaviour
    {
        void Awake()
        {
            var weaponHud = FindObjectOfType<ResourcesWeaponHUD>();
            var controller = ToggleWeapon.Create(weaponHud);
            
            var input = FindObjectOfType<ToggleWeaponButton>();
            input.Inject(controller);
        }
    }
}