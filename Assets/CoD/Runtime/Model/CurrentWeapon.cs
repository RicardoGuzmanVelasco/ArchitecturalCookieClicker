using System;

namespace CoD.Runtime.Model
{
    public class CurrentWeapon : Weapon
    {
        readonly Equipment equipment;

        public override string Id => equipment.Current.Id;
        public override Magazine CurrentMagazine => equipment.Current.CurrentMagazine;

        public override int RemainingMagazines => equipment.Current.RemainingMagazines;

        public CurrentWeapon(Equipment equipment) : base("current", new Magazine(0), 0)
        {
            this.equipment = equipment;
        }

        public override bool HasBullets()
        {
            return equipment.Current.HasBullets();
        }

        public override bool CanReload()
        {
            return equipment.Current.CanReload();
        }

        public override void Shoot()
        {
            equipment.Current.Shoot();
        }

        public override bool IsFull()
        {
            return equipment.Current.IsFull();
        }

        public override void Reload()
        {
            equipment.Current.Reload();
        }

        public override bool HasMagazines()
        {
            return equipment.Current.HasMagazines();
        }

        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "current is " + equipment.Current.ToString();
        }
    }
}