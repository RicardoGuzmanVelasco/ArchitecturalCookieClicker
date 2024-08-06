namespace CoD.Runtime.Model
{
    public class Weapon
    {
        public string Id { get; }
        public Magazine CurrentMagazine { get; }
        public int RemainingMagazines { get; }

        public Weapon(string id, int magazineCapacity, int magazineCount)
        {
            Id = id;
            CurrentMagazine = new Magazine(magazineCapacity);
            RemainingMagazines = magazineCount;
        }
        
    }
}