using ZooObject.AnimalBase;
using ZooObject.BodyParts;
using ZooObject.Interfaces;

namespace ZooObject.Animals;

public class Lion : Mammal, IGiveMilk
{
    public Tail Tail { get; private set; }

    public Lion() : base("ráaw")
    {
        Tail = new Tail();
    }

    public void GiveMilk()
    {
        Console.WriteLine("Lion giving milk to cubs.");
    }
}
