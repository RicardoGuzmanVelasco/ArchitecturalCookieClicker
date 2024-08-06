namespace CoD.Runtime.ViewAbstractions
{
    public interface WeaponHUD
    {
        void Refresh(string id, int currentAmmo, int maxAmmo); //Los dos últimos es un magazine, pero no conozco modelo
    }
}