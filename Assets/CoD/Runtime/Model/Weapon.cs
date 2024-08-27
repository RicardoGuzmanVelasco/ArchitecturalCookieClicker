using UnityEngine;

namespace CoD.Runtime.Model
{
    public class Weapon
    {
        public string Id { get; }
        public Magazine CurrentMagazine { get; }
        public int RemainingMagazines { get; private set; }

        public Weapon(string id, int magazineCapacity, int magazineCount)
        {
            Id = id;
            CurrentMagazine = new Magazine(magazineCapacity);
            RemainingMagazines = magazineCount;
        }
        
        public bool CanShoot()
        {
            return CurrentMagazine.HasAmmo();
        }

        public void Shoot()
        {
            Debug.Assert(CanShoot());
            CurrentMagazine.Shoot();
        }

        public bool IsFull()
        {
            return CurrentMagazine.IsFull();
        }
        
        public void Reload()
        {
            CurrentMagazine.Refill();
            RemainingMagazines--;
            Debug.Assert(RemainingMagazines >= 0);
        }

        public bool HasMagazines()
        {
            return RemainingMagazines > 0;
        }
    }
}