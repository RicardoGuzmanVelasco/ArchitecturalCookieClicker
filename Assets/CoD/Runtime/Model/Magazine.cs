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

        public void Shoot()
        {
            Ammo--;
        }
    }
}