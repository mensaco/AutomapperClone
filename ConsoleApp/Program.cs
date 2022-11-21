#nullable enable

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

A a = new A() { Id = 19, Name = "Mensaco" };
B b = Mapper.Map(a);

Console.WriteLine(b.Id);
Console.WriteLine(b.Name);


[Map]
public class A
{
    public int Id { get; set; }
    public string? Name { get; set; } 

}

[Map]
public class B
{
    public int Id { get; set; }
    public string? Name { get; set; }

}


public class MapAttribute : Attribute
{

}