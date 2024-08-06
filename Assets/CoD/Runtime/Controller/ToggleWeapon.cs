using CoD.Runtime.Model;

namespace CoD.Runtime.Controller
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
            view.Refresh(model.Current.Id);
        }
        
        public static ToggleWeapon Create(WeaponHUD view) => new ToggleWeapon(Equipment.Default(), view);
    }
}