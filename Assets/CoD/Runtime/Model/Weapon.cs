namespace CoD.Runtime.Model
{
    public class Weapon
    {
        public string Id { get; }
        public Magazine CurrentMagazine { get; }
        int remainingMagazines;
        
        public Weapon(string id, int magazineCapacity, int magazineCount)
        {
            Id = id;
            CurrentMagazine = new Magazine(magazineCapacity);
            remainingMagazines = magazineCount;
        }
        
    }
}