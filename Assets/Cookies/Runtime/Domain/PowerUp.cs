
public class PowerUp
{
    public int Price { get; private set; } = 5;
    public int Level { get; private set; } = 1;

    public void AddLevel()
    {
        Level++;
        Price = 5 * Level;
    }
}
