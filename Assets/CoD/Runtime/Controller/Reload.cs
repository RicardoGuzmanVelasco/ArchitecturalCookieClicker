using CoD.Runtime.Model;
using CoD.Runtime.ViewAbstractions;

namespace CoD.Runtime.Controller
{
    public class Reload
    {
        readonly Weapon currentWeapon;
        readonly WeaponHUD view;
        
        public Reload(Weapon currentWeapon, WeaponHUD view)
        {
            this.view = view;
            this.currentWeapon = currentWeapon;
        }

        public void Run()
        {
            if (currentWeapon.CanReload())
                RunOnce();
            else
                ShowFeedback();
        }

        void ShowFeedback()
        {
            if (currentWeapon.IsFull())
                view.WarnFull();
            else if (!currentWeapon.HasMagazines())
                view.WarnEmpty();
        }

        void RunOnce()
        {
            currentWeapon.Reload();
            view.Refresh(currentWeapon);
        }
    }
}