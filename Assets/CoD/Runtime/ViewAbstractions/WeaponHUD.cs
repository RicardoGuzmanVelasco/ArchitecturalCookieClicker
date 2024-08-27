using CoD.Runtime.Model;

namespace CoD.Runtime.ViewAbstractions
{
    public interface WeaponHUD
    {
        void Refresh(Weapon equippedWeapon);
        void WarnFull();
        void WarnEmpty();
    }
}