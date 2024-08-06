using CoD.Runtime.Model;

namespace CoD.Runtime.ViewAbstractions
{
    public class ToggleWeapon
    {
        Equipment model;
        WeaponHUD view;
        
        public ToggleWeapon(Equipment model, WeaponHUD view)
        {
            this.model = model;
            this.view = view;
        }

        public void Run()
        {
            model.Toggle();
            
            //puaj, qué verboso se nos queda, ¿verdad? Si tan solo la view recibiera el modelo... :(
            var currentWeapon = model.Current;
            view.Refresh
            (
                currentWeapon.Id,
                currentWeapon.CurrentMagazine.Ammo,
                currentWeapon.CurrentMagazine.Capacity,
                currentWeapon.RemainingMagazines
            );
        }
        
        public static ToggleWeapon Create(WeaponHUD view) => new ToggleWeapon(Equipment.Default(), view);
    }
}