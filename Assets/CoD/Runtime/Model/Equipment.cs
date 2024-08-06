using System;

namespace CoD.Runtime.Model
{
    public class Equipment
    {
        Weapon primary;
        Weapon secondary;

        bool primaryIsCurrent = true;
        
        public Weapon Current => primaryIsCurrent ? primary : secondary;
        
        public Equipment(Weapon primary, Weapon secondary)
        {
            this.primary = primary;
            this.secondary = secondary;
        }
        
        public void Toggle()
        {
            primaryIsCurrent = !primaryIsCurrent;
        }
        
        public static Equipment Default()
        {
            return new Equipment(
                new Weapon("ak47", 30, 3),
                new Weapon("m1911", 7, 5)
            );
        }
    }
}