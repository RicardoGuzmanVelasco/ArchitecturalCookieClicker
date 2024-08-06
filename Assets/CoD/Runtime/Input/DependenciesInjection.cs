using CoD.Runtime.Input;
using CoD.Runtime.ViewAbstractions;
using UnityEngine;

namespace CoD.Runtime.View
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