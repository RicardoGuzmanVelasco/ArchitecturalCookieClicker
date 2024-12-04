using System;

public class Container
{
    public int Current { get; private set; }
    public int Capacity { get; private set; }

    public Container(int capacity)
    {
        Capacity = capacity;
    }

    public void Add(int amount)
    {
        if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount));
        Current += amount;
        if (Current > Capacity) Current = Capacity;
    }

    public void Subtract(int amount)
    {
        if (Current < amount) throw new InvalidOperationException("No te puedes endeudar de galletas");
        Current -= amount;
    }

    public bool IsFull()
    {
        return Current == Capacity;
    }
}