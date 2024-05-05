
var p1 = new Person("siddharth", "prasad newar", new DateOnly(2001, 3, 25));
var p2 = new Person("anu", "prasad newar", new DateOnly(2001, 3, 7));

p1.Pets.Add(new Dog("Sheru"));
p1.Pets.Add(new Dog("Kalu"));

p2.Pets.Add(new Cat("tom"));

List<Person> people = [p1, p2];

foreach (var person in people)
{
    Console.WriteLine($"{person}");
    foreach(var pet in person.Pets)
    {
        Console.WriteLine($"                {pet}");
    }
}
public class Person(string firstname, string lastname, DateOnly bd)
{
    public string First { get; } = firstname;
    public string Last { get; } = lastname;
    public DateOnly Bd { get; } = bd;

    public List<Pet> Pets { get; } = new();

    public override string ToString()
    {
        return $"Human {First} {Last}";
    }
}

public abstract class Pet(string firstname){
    public string First { get; } = firstname;

    public abstract string MakeNoise();

    public override string ToString()
    {
        return $"{First} and I am a {GetType().Name} and I make noise {MakeNoise()}";
    }

}

public class Cat(string firstname): Pet(firstname)
{
    public override string MakeNoise() => "meow";
}

public class Dog(string firstname): Pet(firstname)
{
    public override string MakeNoise() => "Bark";
}
