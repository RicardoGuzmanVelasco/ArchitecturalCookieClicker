namespace CoD.Runtime.Model
{
    public class Weapon
    {
        public string Id { get; }
        Magazine current;
        int remainingMagazines;
        
        public Weapon(string id, int magazineCapacity, int magazineCount)
        {
            Id = id;
            current = new Magazine(magazineCapacity);
            remainingMagazines = magazineCount;
        }
        
    }
}