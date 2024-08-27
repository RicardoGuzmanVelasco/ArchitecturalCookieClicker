using UnityEngine;

namespace CoD.Runtime.Model
{
    public class Magazine
    {
        public int Ammo { get; private set; }
        public int Capacity { get; }
        
        public Magazine(int capacity)
        {
            Capacity = capacity;
            Ammo = capacity;
        }
        
        public bool HasAmmo()
        {
            return Ammo > 0;
        }

        public void Shoot()
        {
            Debug.Assert(HasAmmo());
            Ammo--;
        }

        public void Refill()
        {
            Ammo = Capacity;
        }

        public bool IsFull()
        {
            return Ammo == Capacity;
        }
    }
}