using CoD.Runtime.Controller;
using CoD.Runtime.Input;
using CoD.Runtime.Model;
using CoD.Runtime.Presentation;
using UnityEngine;

namespace CoD.Runtime.Main
{
    public class DependenciesInjection : MonoBehaviour
    {
        void Awake()
        {
            var weaponHud = FindObjectOfType<ResourcesWeaponHUD>();
            var model = Equipment.Default();
            var controller = ToggleWeapon.Create(weaponHud, model);
            
            var toggleWeaponInput = FindObjectOfType<ToggleWeaponButton>();
            toggleWeaponInput.Inject(controller);
            
            var shootInput = FindObjectOfType<ShootWhenPressLetterQ>();
            var shootController = new Shoot(model, weaponHud);
            shootInput.Inject(shootController);
        }
    }
}