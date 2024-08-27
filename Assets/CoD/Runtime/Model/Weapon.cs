using UnityEngine;

namespace CoD.Runtime.Model
{
    public class Weapon
    {
        public virtual string Id { get; }
        public virtual Magazine CurrentMagazine { get; }
        public virtual int RemainingMagazines { get; private set; }

        public Weapon(string id, int magazineCapacity, int magazineCount)
        {
            Id = id;
            CurrentMagazine = new Magazine(magazineCapacity);
            RemainingMagazines = magazineCount;
        }
        
        public virtual bool CanShoot()
        {
            return CurrentMagazine.HasAmmo();
        }

        public virtual bool CanReload()
        {
            return CanShoot() && !IsFull();
        }

        public virtual void Shoot()
        {
            Debug.Assert(CanShoot());
            CurrentMagazine.Shoot();
        }

        public virtual bool IsFull()
        {
            return CurrentMagazine.IsFull();
        }
        
        public virtual void Reload()
        {
            CurrentMagazine.Refill();
            RemainingMagazines--;
            Debug.Assert(RemainingMagazines >= 0);
        }

        public virtual bool HasMagazines()
        {
            return RemainingMagazines > 0;
        }
    }
}