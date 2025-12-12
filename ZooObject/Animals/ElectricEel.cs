using ZooObject.AnimalBase;
using ZooObject.Interfaces;

namespace ZooObject.Animals;

public class ElectricEel : Fish, ISwim
{
    public ElectricEel() : base("fíw-fíw")
    {
    }

    public void Swim()
    {
        Console.WriteLine("The electric eel swims silently.");
    }
}
