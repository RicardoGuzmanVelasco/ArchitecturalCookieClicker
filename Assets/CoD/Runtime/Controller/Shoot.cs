using CoD.Runtime.Model;
using CoD.Runtime.ViewAbstractions;

namespace CoD.Runtime.Controller
{
    public class Shoot
    {
        readonly Equipment model;
        readonly WeaponHUD view;
        readonly NoBulletsFeedback viewNoBullets;
        
        public Shoot(Equipment model, WeaponHUD view, NoBulletsFeedback viewNoBullets)
        {
            this.model = model;
            this.view = view;
            this.viewNoBullets = viewNoBullets;
        }

        public void Run()
        {
            var weapon = model.Current;
            if (!weapon.CanShoot())
                return;
            else {
                weapon.Shoot();
                view.Refresh(weapon);
            }
        }
    }
}