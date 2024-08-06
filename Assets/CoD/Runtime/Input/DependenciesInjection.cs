using CoD.Runtime.View;
using CoD.Runtime.ViewAbstractions;
using UnityEngine;

namespace CoD.Runtime.Input
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