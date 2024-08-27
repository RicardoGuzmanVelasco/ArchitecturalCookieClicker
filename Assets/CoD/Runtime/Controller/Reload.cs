using CoD.Runtime.Model;
using CoD.Runtime.ViewAbstractions;

namespace CoD.Runtime.Controller
{
    public class Reload
    {
        readonly Equipment model;
        readonly Weapon currentWeapon;
        readonly WeaponHUD view;
        
        public Reload(Equipment model, Weapon currentWeapon, WeaponHUD view)
        {
            this.model = model;
            this.view = view;
            this.currentWeapon = currentWeapon;
        }

        public void Run()
        {
            if (model.Current.CanReload())
                RunOnce();
            else
                ShowFeedback();
        }

        void ShowFeedback()
        {
            if (model.Current.IsFull())
                view.WarnFull();
            else if (!model.Current.HasMagazines())
                view.WarnEmpty();
        }

        void RunOnce()
        {
            model.Current.Reload();
            view.Refresh(model.Current);
        }
    }
}