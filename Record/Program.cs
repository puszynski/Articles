var person = new Person()
{
    Name = "Bob",
    Age = 9
};
person.Age = 10;
//A record type is a value type and an immutable type that can not be changed once created?

var user = new User()
{
    Name = "Jhon",
    Age = 20
};
//user.Age = 21; not possible

var userClass = new UserClass()
{
    Name = "Jhon",
    Age = 20
};
//userClass.Age = 21; not possible

var userClass2 = new UserClass2("Bob", 35);
//userClass2.Age = 12;

var pet = new Pet("Bob", 35);
//pet.Age = 10; not possible

var hybrid = new Hybrid("Jhon", 22)
{
    Status = "Ok"
};
//hybrid.Age = 25; not possible
hybrid.Status = "NotAccepted;";


var hybrid2 = new Hybrid2()
{
    Name = "Mike",
    Age = 33,
    Status = "Ok"
};
hybrid2.Status = "NotAccepted";
//hybrid2.Age = 50; not possible








//is not immutable yet
record Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
//now immutable (C# 9)
record User
{
    public string Name { get; init; }
    public int Age { get; init; }
}

class UserClass
{
    public string Name { get; init; }
    public int Age { get; init; }
}

class UserClass2
{
    public UserClass2(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; private set; }
    public int Age { get; private set; }
}


//mutable properties (positional parameters)
record Pet(string Name, int Age);

public record WildAnimal(string Name, int Age)
{
    public string Color { get; init; }
}


//mixed
record Hybrid(string Name, int Age)
{
    public string Status { get; set; }
}

record Hybrid2()
{
    public string Name { get; init; }
    public int Age { get; init; }
    public string Status { get; set; }
}
