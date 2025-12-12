using ZooObject.AnimalBase;
using ZooObject.Interfaces;

namespace ZooObject.Animals;

public class FlyingFish : Fish, ISwim, IFly
{
    public FlyingFish() : base("plaa wâay náam")
    {
    }

    public void Fly()
    {
        Console.WriteLine("Flying fish gliding.");
    }

    public void Swim()
    {
        Console.WriteLine("The flying fish swims.");
    }
}
