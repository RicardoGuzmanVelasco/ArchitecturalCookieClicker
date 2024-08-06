namespace CoD.Runtime.ViewAbstractions
{
    public interface WeaponHUD
    {
        //Los tres últimos es un magazine, pero no conozco modelo
        void Refresh(string id, int currentAmmo, int maxAmmo, int remainingMagazines);
    }
}