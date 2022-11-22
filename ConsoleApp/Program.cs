#nullable enable

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



A a = new A() { Id = 19, Value = "Mensaco" };
B b = Generator.Mapper.Map(a);

Console.WriteLine(b.Id);
Console.WriteLine(b.Name);
