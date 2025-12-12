using ZooObject.AnimalBase;
using ZooObject.Interfaces;

namespace ZooObject.Animals;

public class Platypus : Mammal, ILayEggs, IGiveMilk, ISwim
{
    public Platypus() : base("chíw-chíw")
    {
    }

    public void LayEggs()
    {
        Console.WriteLine("The platypus lays eggs.");
    }

    public void GiveMilk()
    {
        Console.WriteLine("The platypus gives milk.");
    }

    public void Swim()
    {
        Console.WriteLine("The platypus swims in the water.");
    }
}
