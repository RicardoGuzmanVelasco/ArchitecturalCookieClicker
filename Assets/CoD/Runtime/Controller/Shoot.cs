using CoD.Runtime.Model;
using CoD.Runtime.ViewAbstractions;

namespace CoD.Runtime.Controller
{
    public class Shoot
    {
        readonly Equipment model;
        readonly WeaponHUD view;
        
        public Shoot(Equipment model, WeaponHUD view)
        {
            this.model = model;
            this.view = view;
        }

        public void Run()
        {
            var weapon = model.Current;

            if (weapon.CanShoot())
                RunOneShoot(weapon);
        }

        void RunOneShoot(Weapon weapon)
        {
            weapon.Shoot();
            view.Refresh(weapon);
        }
    }
}