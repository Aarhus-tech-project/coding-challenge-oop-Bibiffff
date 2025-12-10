using ZooObject.AnimalBase;
using ZooObject.BodyParts;

namespace ZooObject.Animals;

public class Caterpillar : Animal
{
    public Wings Wings { get; private set; }

    public Caterpillar() : base("Squeek", "Insect")
    {
        Wings = new Wings(); // starts unused
    }

    public void Transform()
    {
        Console.WriteLine("Caterpillar becomes a butterfly.");
    }
}
