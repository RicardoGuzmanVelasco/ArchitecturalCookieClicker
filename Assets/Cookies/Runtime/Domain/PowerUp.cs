
public class PowerUp
{
    public int Price => 5 * Level;
    public int Level { get; private set; } = 1;

    public void AddLevel()
    {
        Level++;
    }
}
