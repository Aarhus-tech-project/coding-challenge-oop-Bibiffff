using ZooObject.ZooSystem;
using ZooObject.Animals;

namespace ZooObject;

internal class Program
{
    static void Main(string[] args)
    {
        var zoo = new Zoo();

        zoo.AddAnimal(new Lion());
        zoo.AddAnimal(new Penguin());
        zoo.AddAnimal(new Bat());
        zoo.AddAnimal(new Platypus());
        zoo.AddAnimal(new Chameleon());
        zoo.AddAnimal(new ElectricEel());
        zoo.AddAnimal(new FlyingFish());

        var cat = new Caterpillar();
        cat.Transform();
        zoo.AddAnimal(cat);

        zoo.MakeAllSounds();
    }
}
