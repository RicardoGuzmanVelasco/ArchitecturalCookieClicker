using CoD.Runtime.Model;
using CoD.Runtime.ViewAbstractions;

namespace CoD.Runtime.Controller
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

        public void RunForTheFirstTime()
        {
            view.Refresh(model.Current);
        }
        
        public void Run()
        {
            model.Toggle();
            view.Refresh(model.Current);
        }
    }
}