using ZooObject.AnimalBase;

namespace ZooObject.ZooSystem;

public class Zoo
{
    private List<Animal> animals = new();

    public void AddAnimal(Animal a)
    {
        animals.Add(a);
    }

    public void MakeAllSounds()
    {
        foreach (var a in animals)
            a.MakeSound();
    }
}
