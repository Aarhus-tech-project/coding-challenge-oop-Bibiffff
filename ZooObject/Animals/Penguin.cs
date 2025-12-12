using ZooObject.AnimalBase;
using ZooObject.BodyParts;
using ZooObject.Interfaces;

namespace ZooObject.Animals;
public class Penguin : Bird, ISwim
{
    public Wings Wings = new Wings();
    public Legs Legs = new Legs();
    public Beak Beak = new Beak();
    public Tail Tail = new Tail();

    public Penguin() : base("gâap-gâap")
    {
    }
    public void Swim()
    {
        Console.WriteLine("Penguin swimming.");
    }
}
