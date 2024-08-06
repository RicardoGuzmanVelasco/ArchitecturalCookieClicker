using CoD.Runtime.Model;

namespace CoD.Runtime.ViewAbstractions
{
    public class ToggleWeapon
    {
        readonly Equipment model;
        readonly WeaponHUD view;
        
        public ToggleWeapon(Equipment model, WeaponHUD view)
        {
            this.model = model;
            this.view = view;
        }

        public void Run()
        {
            model.Toggle();
            view.Refresh(model.Current);
        }
        
        public static ToggleWeapon Create(WeaponHUD view) => new ToggleWeapon(Equipment.Default(), view);
    }
}