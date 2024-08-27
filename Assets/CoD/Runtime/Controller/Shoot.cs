using CoD.Runtime.Model;
using CoD.Runtime.ViewAbstractions;

namespace CoD.Runtime.Controller
{
    public class Shoot
    {
        readonly Equipment model;
        readonly Reload delegatedController;
        readonly WeaponHUD view;
        
        public Shoot(Equipment model, Reload delegatedController, WeaponHUD view)
        {
            this.view = view;
            this.delegatedController = delegatedController;
            this.model = model;
        }

        public void Run()
        {
            var weapon = model.Current;

            if (weapon.HasBullets())
                RunOneShoot(weapon);
            else
                delegatedController.Run();
        }

        void RunOneShoot(Weapon weapon)
        {
            weapon.Shoot();
            view.Refresh(weapon);
        }
    }
}