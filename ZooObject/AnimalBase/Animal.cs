using System;

namespace ZooObject.AnimalBase;
public abstract class Animal
{
    public string Sound { get; protected set; }
    public string Category { get; protected set; }


    protected Animal(string sound, string category)
    {
        Sound = sound;
        Category = category;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine($"{GetType().Name}: {Sound}");
    }
}
