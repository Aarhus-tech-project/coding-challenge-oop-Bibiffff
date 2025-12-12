using ZooObject.AnimalBase;
using ZooObject.BodyParts;
using ZooObject.Interfaces;

namespace ZooObject.Animals;

public class Bat : Mammal, IFly
{

    public Wings Wings = new Wings();

    public Bat() : base("fʉ́t-fʉ́t")
    {
    }

    public void Fly()
    {
        Console.WriteLine("Bat flying");
    }
}
